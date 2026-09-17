# Alipay AMS(Alipay Merchant Services) C# Bindings 
```
Language：C#
Release ^2.3.0
Copyright：Ant financial services group
```

`## Documentation
`
Please see the [API docs](https://global.alipay.com/docs/) for the most up-to-date documentation.

## Usage

### Preparing

You need the following Integration information before starting:
```
clientId=your_client_id_here
privateKey=your_private_key_here
alipayPublicKey=your_public_key_here
gatewayUrl=the_alipay_gateway_endpoint
```

Please see the [developer docs](https://global.alipay.com/developer) for help with getting the above information.

see `./ams-dotnet/src/example/Program.cs` for more demo usage.

### Meter event upload

`meter/createSession` uses the regular signed AMS transport. Use its session ID
to call `meter/uploadEvent` through `ExecuteWithHeaders`:

```csharp
var request = new AlipayMeterUploadEventRequest { Meters = meters };
var response = client.ExecuteWithHeaders(
    request,
    new Dictionary<string, string> { ["X-Session-Id"] = sessionId });
```

The SDK sends `meter/uploadEvent` to the gateway URL configured on the client,
without sandbox path rewriting, request signing, response signature verification,
or automatic retries. This API requires HTTP/2.

## Advanced Topic

### Integration Best Practice

Create optimal payment experiences for your customers by following these [best practices](https://global.alipay.com/doc/ams_upm/bp) for integrations.

### Using API Mock

We provide an API mocking tool(currently in BETA version) for you to easily test exceptional cases. 

Below are some of the default out-of-box mocking rules that basically use the payment amount value to identify the desired mock response:

|API|when which input parameter|equals what|then you get a response of|
|---|---|---|---|
|ams/api/v1/payments/pay|payToAmount.value|9901|UNKNOWN_EXCEPTION|
|ams/api/v1/payments/pay|payToAmount.value|9902|network timeout|
|ams/api/v1/payments/inquiryPayment|payToAmount.value of the corresponding PAY request|9903|UNKNOWN_EXCEPTION|
|ams/api/v1/payments/inquiryPayment|payToAmount.value of the corresponding PAY request|9904|network timeout|

To use this mocking tool:

1. Set gatewayUrl=https://isandbox.alipaydev.com
2. Set alipayPublicKey to a fixed value that you can get from us through sandbox_service@alibaba-inc.com.

### Acceptance testing

Pass all the acceptance test cases in the Alipay Developer Center to ensure a high quality integration. Especially, test exceptions by using test cases.

## To get help

If you have any question or feedbacks regarding this sdk, please contact us at sandbox_service@alibaba-inc.com.

For other tech integration related issues, please reach us through overseas_support@service.alibaba.com. 


## FAQ

### What if I only need to use the digital signature feature ?

See [Digital signature](https://global.alipay.com/doc/ams/digital_signature) for details about the signature algorithm used for data transmission.

`./ams-dotnet/src/com/alipay/ams/util/SignatureUtil.cs` provides static utility methods that you can directly use.

## Change history

|Date|Version|Content|Backward compatible?|
|---|---|---|---|
|2020/11/13|1.1|Add Cashier Payment and Auto Debit support.|YES|
|2020/10/10|1.0|v1 release|-|

## API Key authentication

See the [complete API Key example](ams-dotnet/src/example/demo/ApiKeyExample.cs). Call `ams_dotnet.demo.ApiKeyExample.Run()` from your application entry point.

Initialize the client with your gateway URL and API Key; existing RSA usage remains supported.
This feature is available in the current source branch and has not been published yet.

Set `ANTOM_GATEWAY_URL` to your regional HTTPS gateway (for example,
`https://open-sea-global.alipay.com` for Asia), `ANTOM_API_KEY` to your key,
`ANTOM_REDIRECT_URL` to your checkout return URL, and `ANTOM_NOTIFY_URL` to your
notification endpoint. The application reads these variables; the SDK does not load them automatically.

The example creates a CARD payment session for USD 1.00 (`100` minor units),
with USD settlement. Use a merchant configured for this combination and a key
with createPaymentSession permission. Replace the example client IP with the
buyer's IP in your application. Exceptions propagate to the caller; a normal
response must still be checked for business success.

```csharp
using System;
using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request.pay;

public class ApiKeyExample
{
    public static void Main()
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
```

- Standard and Restricted keys use the same client. TEST/PROD in the key selects
  the request environment; do not add a sandbox path to the gateway URL.
- Creating a session does not mean payment is complete. Notifications still use
  the existing signature verification mechanism.
- File upload is not supported with API Key authentication.
