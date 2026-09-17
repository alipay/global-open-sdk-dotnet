using System;
using System.Text;
using System.Text.RegularExpressions;

namespace com.alipay.ams.api
{
    internal sealed class ApiKeyAuth
    {
        private readonly string key;
        private readonly bool sandbox;
        internal string ClientId { get; }
        internal string GatewayUrl { get; }

        internal ApiKeyAuth(string gatewayUrl, string apiKey)
        {
            Uri gateway;
            if (!Uri.TryCreate(gatewayUrl, UriKind.Absolute, out gateway)
                || gateway.Scheme != "https" || string.IsNullOrEmpty(gateway.Host)
                || gateway.UserInfo != "" || gateway.AbsolutePath != "/"
                || gateway.Query != "" || gateway.Fragment != "")
                throw new ArgumentException("API Key requires an absolute HTTPS gateway without credentials, path, query or fragment");
            try
            {
                var parts = apiKey.Split(new[] { '_' }, 4);
                if (parts.Length != 4 || (parts[0] != "isak" && parts[0] != "irak")
                    || (parts[1] != "TEST" && parts[1] != "PROD")
                    || !Regex.IsMatch(parts[2], @"\A[A-Za-z0-9+/]+\z")
                    || !Regex.IsMatch(parts[3], @"\A[A-Za-z0-9_-]+\z"))
                    throw new ArgumentException();
                var decoded = Convert.FromBase64String(parts[2] + new string('=', (4 - parts[2].Length % 4) % 4));
                if (decoded.Length == 0 || Convert.ToBase64String(decoded).TrimEnd('=') != parts[2])
                    throw new ArgumentException();
                ClientId = new UTF8Encoding(false, true).GetString(decoded);
                sandbox = parts[1] == "TEST";
            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid API Key format; expected Standard or Restricted TEST/PROD key");
            }
            key = apiKey;
            GatewayUrl = gatewayUrl.TrimEnd('/');
        }

        internal string Path(string path)
        {
            if (path != null && path.StartsWith("/ams/sandbox/api/", StringComparison.Ordinal))
                path = "/ams/api/" + path.Substring("/ams/sandbox/api/".Length);
            if (path == null || !path.StartsWith("/ams/api/", StringComparison.Ordinal)
                || path.Contains("?") || path.Contains("#"))
                throw new ArgumentException("API Key requires an ordinary /ams/api/ request path");
            return sandbox ? "/ams/sandbox/api/" + path.Substring("/ams/api/".Length) : path;
        }

        internal string Authorization { get { return "Bearer " + key; } }
        internal string Redact(string text) { return text.Replace(key, "[REDACTED]"); }
    }
}
