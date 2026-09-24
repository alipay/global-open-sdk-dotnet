# Antom SDK for .NET

Latest release: **2.3.2**

## Installation

Requires a project targeting .NET 8 (`net8.0`) or a compatible newer framework.
Run this command in the directory containing your project file:

```sh
dotnet add package global-open-sdk-dotnet
```

## Quick start

- **RSA:** follow the [configuration](#rsa-configuration) and [inline example](#rsa-client) below.
- **API Key (limited availability):** follow the [setup guide](docs/api-key-client.md) and run the [sandbox example](examples/ApiKeyPaymentSession/Program.cs).
- Browse [more examples](ams-dotnet/src/example) and the [API documentation](https://global.alipay.com/docs/).

RSA and API Key clients share request/response models. File uploads and notification
verification still require RSA credentials.

### RSA configuration

Before using the RSA client, prepare these values from your Antom integration:

```properties
gatewayUrl=your_regional_https_gateway
clientId=your_client_id
merchantPrivateKey=your_merchant_private_key
alipayPublicKey=your_antom_public_key
```

The examples read them from `ANTOM_GATEWAY_URL`, `ANTOM_CLIENT_ID`,
`ANTOM_MERCHANT_PRIVATE_KEY`, and `ANTOM_PUBLIC_KEY`, respectively.
Keep keys in server-side configuration. Replace sample order data and callback
URLs with your own values before sending a request.

### RSA client

The following C# method-body fragment initializes the client. Select the single
operation you need from the [payment examples](ams-dotnet/src/example/demo/PayDemo.cs).
The repository's `Program.cs` runs multiple operations, including refunds and
cancellations; do not run it unchanged as a payment quick start.

```csharp
var client = new com.alipay.ams.api.DefaultAlipayClient(
    System.Environment.GetEnvironmentVariable("ANTOM_GATEWAY_URL"),
    System.Environment.GetEnvironmentVariable("ANTOM_CLIENT_ID"),
    System.Environment.GetEnvironmentVariable("ANTOM_MERCHANT_PRIVATE_KEY"),
    System.Environment.GetEnvironmentVariable("ANTOM_PUBLIC_KEY"));
```

### API Key client (limited availability)

> API Key access is not yet available to all merchants. Use this client only if
> API Key access has been enabled for your account; otherwise, use RSA.

Set `ANTOM_GATEWAY_URL` and `ANTOM_API_KEY` in your server environment.
This initializes the client; see the [setup guide](docs/api-key-client.md) for a
complete sandbox request and its additional configuration. Place the using
directive at file scope and the initialization statements inside a method.

```csharp
using com.alipay.ams.api;

using var client = new ApiKeyAlipayClient(
    Environment.GetEnvironmentVariable("ANTOM_GATEWAY_URL"),
    Environment.GetEnvironmentVariable("ANTOM_API_KEY"));
```

## Upgrade notes

Billing integrations: `availableAmount` now uses `Amount`; the `AvailableAmount`
model has been removed.

## Meter event upload

`meter/createSession` uses the regular signed AMS transport. Use its session ID
to call `meter/uploadEvent` through `ExecuteWithHeaders`:

The fragment below assumes an initialized RSA client, a valid session ID from
`meter/createSession`, and a populated collection of meter event batches.

```csharp
// Requires: using com.alipay.ams.api.request.billing;
//           using System.Collections.Generic;
var request = new AlipayMeterUploadEventRequest { Meters = meters };
var response = client.ExecuteWithHeaders(
    request,
    new Dictionary<string, string> { ["X-Session-Id"] = sessionId });
```

The SDK sends `meter/uploadEvent` to the gateway URL configured on the client,
without sandbox path rewriting, request signing, response signature verification,
or automatic retries. This API requires HTTP/2.

## Support

For integration questions, contact overseas_support@service.alibaba.com.
