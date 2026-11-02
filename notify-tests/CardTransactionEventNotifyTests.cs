using System.Text.Json;
using System.Text.Json.Nodes;
using com.alipay.ams.api.request.notify;
using com.alipay.ams.util;

static class CardTransactionEventNotifyTests
{
    private static JsonNode WithoutNulls(JsonNode value)
    {
        if (value is JsonObject obj)
        {
            var result = new JsonObject();
            foreach (var pair in obj)
                if (pair.Value != null) result[pair.Key] = WithoutNulls(pair.Value);
            return result;
        }
        return value?.DeepClone();
    }

    public static void Run()
    {
        var fixtures = JsonNode.Parse(File.ReadAllText(
            Path.Combine(AppContext.BaseDirectory, "../../../card-transaction-event-notify.json"))).AsArray();
        if (typeof(AlipayCardTransactionEventNotify).GetProperties().Length != 22)
            throw new Exception("Notification must expose exactly the 22 event fields");
        foreach (var options in new[] {
            JsonSerializerOptionsFactory.WriteIndented, JsonSerializerOptionsFactory.WriteNotIndented })
        {
            foreach (var fixture in fixtures)
            {
                var body = fixture["body"].DeepClone().AsObject();
                body["futureField"] = new JsonObject { ["ignored"] = true };
                var notify = JsonSerializer.Deserialize<AlipayCardTransactionEventNotify>(body.ToJsonString(), options);
                var encoded = JsonNode.Parse(JsonSerializer.Serialize(notify, JsonSerializerOptionsFactory.WriteIndented));
                if (!JsonNode.DeepEquals(WithoutNulls(fixture["body"]), encoded))
                    throw new Exception("Event field or nested type mismatch: " + fixture["name"]);
            }
        }
        var auth = JsonSerializer.Deserialize<AlipayCardTransactionEventNotify>(
            fixtures[0]["body"].ToJsonString(), JsonSerializerOptionsFactory.WriteIndented);
        if (auth.AuthTime != null) throw new Exception("AUTH authTime must remain absent");
        var capture = JsonSerializer.Deserialize<AlipayCardTransactionEventNotify>(
            fixtures[1]["body"].ToJsonString(), JsonSerializerOptionsFactory.WriteIndented);
        if (capture.OutAmount.Value != "0" || capture.OutAmount.Currency != "USD" ||
            capture.TransactionAmount.Value != "30000" || capture.InAmount != null ||
            capture.AuthTime != "2026-07-09T10:35:10+00:00" || capture.BalanceType != "ANTOM_BIZ_ACCOUNT")
            throw new Exception("CAPTURE zero outflow or authTime changed");
        Console.WriteLine("Card transaction event notify: PASS (6 fixtures, both SDK JSON options)");
    }
}
