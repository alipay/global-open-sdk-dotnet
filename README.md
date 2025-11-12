# Alipay AMS(Alipay Merchant Services) C# Bindings 
```
Language：C#
Releass ^2.1.7
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

