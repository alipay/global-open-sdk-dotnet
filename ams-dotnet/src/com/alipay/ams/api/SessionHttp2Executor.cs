using System;
using System.Collections.Generic;
using System.Text.Json;
using com.alipay.ams.api.request;
using com.alipay.ams.api.response;
using com.alipay.ams.util;

namespace com.alipay.ams.api
{
    internal static class SessionHttp2Executor
    {
        private const string SessionHeader = "X-Session-Id";

        internal static TAMSResponse Execute<TAMSResponse>(
            string gatewayUrl,
            AMSRequest<TAMSResponse> request,
            Dictionary<string, string> extraHeaders)
            where TAMSResponse : AMSResponse
        {
            var sessionId = ValidateAndGetSessionId(extraHeaders);
            var responseBody = Http2JsonTransport.Post(
                gatewayUrl,
                request.GetRequestURI(),
                sessionId,
                request.BuildBody());

            using var responseDocument = JsonDocument.Parse(responseBody);
            if (!responseDocument.RootElement.TryGetProperty("result", out var result)
                || result.ValueKind == JsonValueKind.Null)
            {
                throw new InvalidOperationException(
                    "Response data error, result field is null. responseBody = " + responseBody);
            }
            var response = JsonSerializer.Deserialize<TAMSResponse>(
                responseBody,
                JsonSerializerOptionsFactory.WriteNotIndented);
            if (response == null)
            {
                throw new InvalidOperationException("Failed to deserialize response body.");
            }
            return response;
        }

        private static string ValidateAndGetSessionId(Dictionary<string, string> extraHeaders)
        {
            string sessionId = null;
            if (extraHeaders != null)
            {
                foreach (var entry in extraHeaders)
                {
                    if (!string.Equals(entry.Key, SessionHeader, StringComparison.OrdinalIgnoreCase))
                    {
                        throw new ArgumentException(
                            "Only X-Session-Id is supported for this API. Unsupported header: " +
                            (entry.Key ?? "<null>"),
                            nameof(extraHeaders));
                    }
                    if (sessionId != null)
                    {
                        throw new ArgumentException(
                            "X-Session-Id must be provided only once.",
                            nameof(extraHeaders));
                    }
                    sessionId = entry.Value;
                }
            }
            if (string.IsNullOrWhiteSpace(sessionId))
            {
                throw new ArgumentException(
                    "X-Session-Id cannot be null or blank.",
                    nameof(extraHeaders));
            }
            if (sessionId.Contains('\r') || sessionId.Contains('\n'))
            {
                throw new ArgumentException(
                    "X-Session-Id cannot contain CR or LF characters.",
                    nameof(extraHeaders));
            }
            return sessionId;
        }
    }
}
