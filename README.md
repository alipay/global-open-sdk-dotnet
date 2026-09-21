# Antom SDK for .NET

Latest release: **2.3.1**

## Installation

```sh
dotnet add package global-open-sdk-dotnet
```

## Quick start

- **API Key:** follow the [setup guide](docs/api-key-client.md) and run the [sandbox example](examples/ApiKeyPaymentSession/Program.cs).
- **RSA:** start with the [payment example](ams-dotnet/src/example/Program.cs).
- Browse [more examples](ams-dotnet/src/example) and the [API documentation](https://global.alipay.com/docs/).

API Key and RSA clients share request/response models. File uploads and notification
verification still require RSA credentials.

## Upgrade notes

Billing integrations: `availableAmount` now uses `Amount`; the `AvailableAmount`
model has been removed.

## Meter event upload

`meter/uploadEvent` requires HTTP/2 and `X-Session-Id`. See the
[usage and requirements](docs/meter-event-upload.md).

## Support

For integration questions, contact overseas_support@service.alibaba.com.
