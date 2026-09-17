// Read ANTOM_GATEWAY_URL, ANTOM_API_KEY, ANTOM_REDIRECT_URL and ANTOM_NOTIFY_URL from the environment.
// Use a TEST key with createPaymentSession permission for sandbox testing.
// This example creates a CARD session for USD 1.00; it does not complete a payment.
// Replace 127.0.0.1 with the buyer's IP. Notifications require a reachable endpoint.

using System;
using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request.pay;

namespace ams_dotnet.demo
{
    public class ApiKeyExample
    {
        public static void Run()
        {
            var client = new DefaultAlipayClient(
                Environment.GetEnvironmentVariable("ANTOM_GATEWAY_URL"),
                Environment.GetEnvironmentVariable("ANTOM_API_KEY"));
            var amount = new Amount("USD", "100");
            var request = new AlipayPaymentSessionRequest
            {
                ProductCode = ProductCodeType.CASHIER_PAYMENT,
                ProductScene = "CHECKOUT_PAYMENT",
                PaymentRequestId = Guid.NewGuid().ToString("N"),
                Order = new Order {
                    ReferenceOrderId = Guid.NewGuid().ToString("N"),
                    OrderDescription = "API Key example", OrderAmount = amount
                },
                PaymentAmount = amount,
                PaymentMethod = new PaymentMethod { PaymentMethodType = "CARD" },
                PaymentFactor = new PaymentFactor { IsAuthorization = false },
                SettlementStrategy = new SettlementStrategy { SettlementCurrency = "USD" },
                Env = new Env { TerminalType = TerminalType.WEB, ClientIp = "127.0.0.1" },
                PaymentRedirectUrl = Environment.GetEnvironmentVariable("ANTOM_REDIRECT_URL"),
                PaymentNotifyUrl = Environment.GetEnvironmentVariable("ANTOM_NOTIFY_URL")
            };
    
            // Transport errors propagate as exceptions; also check the business result.
            var response = client.Execute(request);
            if (response.Result == null || response.Result.ResultStatus != ResultStatusType.S
                || response.Result.ResultCode != "SUCCESS")
                throw new InvalidOperationException("Session creation was not successful: "
                    + (response.Result == null ? "missing result" : response.Result.ResultCode));
            if (string.IsNullOrEmpty(response.PaymentSessionId))
                throw new InvalidOperationException("Missing paymentSessionId");
            // Use response.PaymentSessionData or the returned URL with your checkout.
            Console.WriteLine("Payment session created");
        }
    }
}
