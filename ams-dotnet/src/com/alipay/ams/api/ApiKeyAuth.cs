using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace com.alipay.ams.api
{
    internal sealed class ApiKeyAuth
    {
        private readonly string apiKey;
        private readonly bool sandbox;
        internal string GatewayUrl { get; }
        internal string Authorization => "Bearer " + apiKey;
        internal static readonly HashSet<string> ReservedHeaders = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Authorization", "Signature", "Client-Id", "Request-Time", "Key-Version", "keyVersion", "Agent-Token",
            "Content-Type", "User-Agent", "X-sdkVersion", "SDK-Version", "Host", "Content-Length",
            "Transfer-Encoding", "Connection", "Proxy-Authorization"
        };

        internal ApiKeyAuth(string gatewayUrl, string apiKey)
        {
            if (apiKey == null || !Regex.IsMatch(apiKey, @"\A(?:isak|irak)_(?:TEST|PROD)_[^_\s\x00-\x1f\x7f]+_[^\s\x00-\x1f\x7f]+\z"))
                throw new ArgumentException("apiKey must be a Standard or Restricted TEST/PROD key", nameof(apiKey));
            if (!Uri.TryCreate(gatewayUrl, UriKind.Absolute, out var uri) || uri.Scheme != "https"
                || string.IsNullOrEmpty(uri.Host) || !string.IsNullOrEmpty(uri.UserInfo)
                || uri.AbsolutePath != "/" || !string.IsNullOrEmpty(uri.Query) || !string.IsNullOrEmpty(uri.Fragment)
                || Regex.IsMatch(gatewayUrl, @"\s"))
                throw new ArgumentException("gatewayUrl must be an HTTPS base URL", nameof(gatewayUrl));
            GatewayUrl = gatewayUrl.TrimEnd('/');
            this.apiKey = apiKey;
            sandbox = apiKey.Split('_')[1] == "TEST";
        }

        internal string Path(string path)
        {
            if (path == null || !Regex.IsMatch(path, @"\A/ams/(?:sandbox/)?api/[A-Za-z0-9_/-]+\z") || path.Contains("//"))
                throw new ArgumentException("request path must be an ordinary /ams/api/ path");
            var normal = path.Replace("/ams/sandbox/api/", "/ams/api/");
            return sandbox ? normal.Replace("/ams/api/", "/ams/sandbox/api/") : normal;
        }

        internal bool ContainsKey(Exception error) => error.ToString().Contains(apiKey);

        internal string Redact(string message) => message?.Replace(apiKey, "[REDACTED]");
    }
}
