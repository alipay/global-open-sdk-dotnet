using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace com.alipay.ams.api
{
    internal static class Http2JsonTransport
    {
        private static readonly HttpClient Client = CreateClient();

        internal static string Post(
            string gatewayUrl,
            string path,
            string sessionId,
            string requestBody)
        {
            var requestUri = BuildRequestUri(gatewayUrl, path);
            using var request = new HttpRequestMessage(HttpMethod.Post, requestUri)
            {
                Version = HttpVersion.Version20,
                VersionPolicy = HttpVersionPolicy.RequestVersionExact,
                Content = new StringContent(requestBody, Encoding.UTF8, "application/json")
            };
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.TryAddWithoutValidation("User-Agent", SdkVersion.UserAgent);
            request.Headers.Add("X-Session-Id", sessionId);

            using var response = Client.SendAsync(request).ConfigureAwait(false).GetAwaiter().GetResult();
            var responseBody = response.Content.ReadAsStringAsync().ConfigureAwait(false).GetAwaiter().GetResult();

            if (response.Version != HttpVersion.Version20)
            {
                throw new HttpRequestException(
                    "This API requires HTTP/2, but negotiated protocol was " + response.Version + ".");
            }
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException(
                    "Response data error, HTTP status=" + (int)response.StatusCode +
                    ", responseBody=" + responseBody);
            }
            return responseBody;
        }

        private static HttpClient CreateClient()
        {
            var handler = new SocketsHttpHandler
            {
                AllowAutoRedirect = false,
                ActivityHeadersPropagator = null,
                UseCookies = false,
                ConnectTimeout = TimeSpan.FromSeconds(15)
            };
            return new HttpClient(handler)
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
        }

        private static Uri BuildRequestUri(string gatewayUrl, string path)
        {
            if (!Uri.TryCreate(gatewayUrl, UriKind.Absolute, out var gateway)
                || gateway.Scheme != Uri.UriSchemeHttps
                || !string.IsNullOrEmpty(gateway.UserInfo)
                || !string.IsNullOrEmpty(gateway.Query)
                || !string.IsNullOrEmpty(gateway.Fragment)
                || (gateway.AbsolutePath != "/" && gateway.AbsolutePath != string.Empty))
            {
                throw new ArgumentException(
                    "gatewayUrl must be an HTTPS origin without path, query, fragment, or user info.",
                    nameof(gatewayUrl));
            }
            if (string.IsNullOrEmpty(path) || !path.StartsWith("/", StringComparison.Ordinal))
            {
                throw new ArgumentException("path must start with /.", nameof(path));
            }
            return new Uri(gateway, path);
        }
    }
}
