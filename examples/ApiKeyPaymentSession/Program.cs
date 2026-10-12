using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request.pay;

var key = RequiredEnv("ANTOM_API_KEY");
if (!key.StartsWith("irak_TEST_", StringComparison.Ordinal))
    throw new ArgumentException("This example requires a Restricted TEST key");
using var client = new ApiKeyAlipayClient(RequiredEnv("ANTOM_GATEWAY_URL"), key);
var notifyUrl = RequiredEnv("ANTOM_NOTIFY_URL");
var amount = new Amount("USD", "100");
var request = new AlipayPaymentSessionRequest
{
    ProductCode = ProductCodeType.CASHIER_PAYMENT,
    ProductScene = "CHECKOUT_PAYMENT",
    PaymentRequestId = "example-session-" + Guid.NewGuid().ToString("N"),
    Order = new Order
    {
        ReferenceOrderId = "example-order-" + Guid.NewGuid().ToString("N"),
        OrderDescription = "API Key sandbox example",
        OrderAmount = amount,
    },
    PaymentAmount = amount,
    PaymentMethod = new PaymentMethod { PaymentMethodType = "CARD" },
    PaymentFactor = new PaymentFactor { IsAuthorization = false },
    SettlementStrategy = new SettlementStrategy { SettlementCurrency = "USD" },
    Env = new Env { TerminalType = TerminalType.WEB, ClientIp = "127.0.0.1" },
    // Use a separate redirect page in a real integration.
    PaymentRedirectUrl = notifyUrl,
    PaymentNotifyUrl = notifyUrl,
};
var response = client.Execute(request);
// Local debugging only: the response contains payment-session credentials.
Console.WriteLine(response);
if (response?.Result?.ResultStatus != ResultStatusType.S || response.Result.ResultCode != "SUCCESS")
    throw new InvalidOperationException("createPaymentSession failed; see the response result");

static string RequiredEnv(string name)
{
    var value = Environment.GetEnvironmentVariable(name);
    if (string.IsNullOrWhiteSpace(value))
        throw new ArgumentException("Missing environment variable: " + name);
    return value;
}
