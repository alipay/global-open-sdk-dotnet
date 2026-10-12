using System.Text.Json;
using com.alipay.ams.util;

using JsonDocument document = JsonDocument.Parse(File.ReadAllText(
    Path.Combine(AppContext.BaseDirectory, "amount-conversion-test-cases.json")));
JsonElement root = document.RootElement;

Check(root.GetProperty("toAmount"), vector => AmountUtil.ToAmount(
    vector.GetProperty("amount").GetString(), vector.GetProperty("currency").GetString()));
Check(root.GetProperty("fromAmount"), vector => AmountUtil.FromAmount(
    vector.GetProperty("value").GetString(), vector.GetProperty("currency").GetString()));
Check(root.GetProperty("validate"), vector =>
{
    AmountUtil.Validate(vector.GetProperty("value").GetString(), vector.GetProperty("currency").GetString());
    return null;
});
foreach (JsonElement vector in root.GetProperty("toAmount").EnumerateArray())
{
    if (vector.TryGetProperty("result", out JsonElement result))
    {
        string currency = vector.GetProperty("currency").GetString();
        string value = result.GetString();
        if (AmountUtil.ToAmount(AmountUtil.FromAmount(value, currency), currency) != value)
            throw new Exception(vector.GetProperty("name").GetString() + " round-trip mismatch");
    }
}

try
{
    AmountUtil.ToAmount(null, "USD");
    throw new Exception("null amount was accepted");
}
catch (ArgumentNullException exception) when (exception.Message.StartsWith("INVALID_ARGUMENT_TYPE:"))
{
}
try
{
    AmountUtil.Validate("1", null);
    throw new Exception("null currency was accepted");
}
catch (ArgumentNullException exception) when (exception.Message.StartsWith("INVALID_ARGUMENT_TYPE:"))
{
}

Console.WriteLine("AmountUtil shared vectors passed");

static void Check(JsonElement vectors, Func<JsonElement, string> call)
{
    foreach (JsonElement vector in vectors.EnumerateArray())
    {
        string name = vector.GetProperty("name").GetString();
        bool expectsError = vector.TryGetProperty("error", out JsonElement error);
        try
        {
            string actual = call(vector);
            if (expectsError) throw new Exception(name + " expected " + error.GetString());
            if (vector.TryGetProperty("result", out JsonElement result) && actual != result.GetString())
                throw new Exception(name + " result mismatch");
        }
        catch (ArgumentException exception)
        {
            if (!expectsError || !exception.Message.StartsWith(error.GetString() + ":")) throw;
        }
    }
}
