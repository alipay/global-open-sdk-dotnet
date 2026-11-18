using System.Text.Json;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request.pay;
using com.alipay.ams.api.response.pay;

static class VaultingPaymentMethodModelTests
{
    public static void Run()
    {
        var detail = new VaultingRequestPaymentMethodDetail {
            PaymentMethodType = "CARD",
            PaymentMethodMetaData = new Dictionary<string, object> {
                ["recurringType"] = "UNSCHEDULED", ["enabled"] = false,
                ["count"] = 0, ["items"] = Array.Empty<string>()
            }
        };
        var request = new AlipayVaultingPaymentMethodRequest { PaymentMethodDetail = detail };
        using var encoded = JsonDocument.Parse(request.BuildBody());
        var metadata = encoded.RootElement.GetProperty("paymentMethodDetail").GetProperty("paymentMethodMetaData");
        if (metadata.GetProperty("recurringType").GetString() != "UNSCHEDULED" ||
            metadata.GetProperty("enabled").GetBoolean() || metadata.GetProperty("count").GetInt32() != 0 ||
            metadata.GetProperty("items").GetArrayLength() != 0)
            throw new Exception("Request metadata serialization changed");
        if (typeof(AlipayVaultingPaymentMethodResponse).GetProperty("PaymentMethodDetail").PropertyType != typeof(PaymentMethodDetail) ||
            typeof(AlipayVaultingQueryResponse).GetProperty("PaymentMethodDetail").PropertyType != typeof(PaymentMethodDetail) ||
            typeof(PaymentMethodDetail).GetProperty("PaymentMethodMetaData") != null)
            throw new Exception("Response detail type changed");
        Console.WriteLine("Vaulting request metadata and response model types: PASS");
    }
}
