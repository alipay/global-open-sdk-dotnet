using System.Text.Json;
using com.alipay.ams.api.request.notify;
using com.alipay.ams.util;

var options = JsonSerializerOptionsFactory.WriteNotIndented;
foreach (var item in new[] {
    ("DISPUTE_CANCELLED", "disputeCancelledTime", "2026-08-03T03:56:00+00:00"),
    ("DEFENSE_SUPPLIED", "defenseSuppliedTime", "2022-09-22T01:10:05-07:00")
}) {
    var body = JsonSerializer.Serialize(new Dictionary<string,string> {
        ["disputeId"] = "d1", ["disputeNotificationType"] = item.Item1, [item.Item2] = item.Item3
    });
    var notify = JsonSerializer.Deserialize<AlipayDisputeNotify>(body, options);
    var actual = item.Item2 == "disputeCancelledTime" ? notify.DisputeCancelledTime : notify.DefenseSuppliedTime;
    var other = item.Item2 == "disputeCancelledTime" ? notify.DefenseSuppliedTime : notify.DisputeCancelledTime;
    if (actual != item.Item3 || other != null || notify.DisputeId != "d1") throw new Exception("Incorrect notification parsing");
    using var encoded = JsonDocument.Parse(JsonSerializer.Serialize(notify, options));
    if (encoded.RootElement.GetProperty(item.Item2).GetString() != item.Item3) throw new Exception("Wire key/time changed");
}
foreach (var body in new[] { "{\"disputeId\":\"legacy\"}", "{\"disputeCancelledTime\":null,\"defenseSuppliedTime\":null}" }) {
    var notify = JsonSerializer.Deserialize<AlipayDisputeNotify>(body, options);
    if (notify.DisputeCancelledTime != null || notify.DefenseSuppliedTime != null) throw new Exception("Missing times must remain null");
}
Console.WriteLine("Dispute notify times: PASS");

DefenseNotificationsTests.Run();
