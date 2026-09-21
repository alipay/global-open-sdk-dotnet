# Meter event upload

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
