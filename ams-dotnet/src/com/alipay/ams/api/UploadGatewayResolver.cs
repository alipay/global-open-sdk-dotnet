using System;
using System.Collections.Generic;

namespace com.alipay.ams.api
{
    internal static class UploadGatewayResolver
    {
        private static readonly IReadOnlyDictionary<string, string> DefaultGateways =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "open-sea-global.alipay.com", "https://open-big-sea.alipay.com" },
                { "open-sea.alipay.com", "https://open-big-sea.alipay.com" },
                { "open-na-global.alipay.com", "https://open-big-na.alipay.com" },
                { "open-na.alipay.com", "https://open-big-na.alipay.com" },
                { "open-de-global.alipay.com", "https://open-big-de-global.alipay.com" }
            };

        internal static string Resolve(string normalGatewayUrl, string explicitUploadGatewayUrl)
        {
            if (!string.IsNullOrWhiteSpace(explicitUploadGatewayUrl))
            {
                return explicitUploadGatewayUrl;
            }
            var gateway = ParseGateway(normalGatewayUrl, true);
            if (!DefaultGateways.TryGetValue(gateway.Host, out var mappedGateway))
            {
                throw new InvalidOperationException(
                    "No default file gateway mapping exists for " + gateway.Host
                    + ". Configure uploadGatewayUrl explicitly.");
            }
            return mappedGateway;
        }

        internal static string NormalizeExplicit(string uploadGatewayUrl)
        {
            return ParseGateway(uploadGatewayUrl, false).GetLeftPart(UriPartial.Authority);
        }

        private static Uri ParseGateway(string gatewayUrl, bool isNormalGateway)
        {
            if (string.IsNullOrWhiteSpace(gatewayUrl))
            {
                throw new ArgumentException("Gateway URL cannot be empty", nameof(gatewayUrl));
            }
            var candidate = gatewayUrl.Trim();
            if (isNormalGateway && !candidate.Contains("://"))
            {
                candidate = "https://" + candidate;
            }
            if (!Uri.TryCreate(candidate, UriKind.Absolute, out var parsed)
                || !string.Equals(parsed.Scheme, Uri.UriSchemeHttps, StringComparison.OrdinalIgnoreCase)
                || string.IsNullOrWhiteSpace(parsed.Host))
            {
                throw new ArgumentException(
                    "Gateway URL must be an absolute HTTPS base URL", nameof(gatewayUrl));
            }
            if (!string.IsNullOrEmpty(parsed.UserInfo)
                || (parsed.AbsolutePath != string.Empty && parsed.AbsolutePath != "/")
                || !string.IsNullOrEmpty(parsed.Query)
                || !string.IsNullOrEmpty(parsed.Fragment))
            {
                throw new ArgumentException(
                    "Gateway URL must not include user info, path, query, or fragment",
                    nameof(gatewayUrl));
            }
            if (isNormalGateway && !parsed.IsDefaultPort && parsed.Port != 443)
            {
                throw new ArgumentException(
                    "gatewayUrl cannot be mapped to a file gateway; configure uploadGatewayUrl explicitly",
                    nameof(gatewayUrl));
            }
            return parsed;
        }
    }
}
