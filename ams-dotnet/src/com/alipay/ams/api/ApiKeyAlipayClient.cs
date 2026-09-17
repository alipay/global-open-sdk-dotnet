using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using com.alipay.ams.api.request;
using com.alipay.ams.api.response;
using com.alipay.ams.util;

namespace com.alipay.ams.api
{
    /// <summary>Independent API Key client. Dispose it when its requests are complete.</summary>
    public sealed class ApiKeyAlipayClient : IDisposable
    {
        private readonly ApiKeyAuth auth;
        private readonly HttpClient client;

        public ApiKeyAlipayClient(string gatewayUrl, string apiKey)
            : this(gatewayUrl, apiKey, new ApiKeyClientOptions()) { }

        public ApiKeyAlipayClient(string gatewayUrl, string apiKey, ApiKeyClientOptions options)
        {
            auth = new ApiKeyAuth(gatewayUrl, apiKey);
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (options.Timeout <= TimeSpan.Zero || options.Timeout.TotalMilliseconds > int.MaxValue)
                throw new ArgumentOutOfRangeException(nameof(options), "Timeout must be positive and finite");
            // This client owns its handler. External handlers cannot weaken TLS or redirect policy.
            client = new HttpClient(new HttpClientHandler { AllowAutoRedirect = false, UseCookies = false })
            {
                Timeout = options.Timeout
            };
        }

        public TAMSResponse Execute<TAMSResponse>(AMSRequest<TAMSResponse> request)
            where TAMSResponse : AMSResponse => ExecuteWithHeaders(request, null);

        public TAMSResponse ExecuteWithHeaders<TAMSResponse>(AMSRequest<TAMSResponse> request,
            Dictionary<string, string> extraHeaders) where TAMSResponse : AMSResponse
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (RequestTransportResolver.RequiresSessionHttp2(HttpMethod.Post.Method, request.GetRequestURI()))
                return SessionHttp2Executor.Execute(auth.GatewayUrl, request, extraHeaders);

            using var message = new HttpRequestMessage(HttpMethod.Post, auth.GatewayUrl + auth.Path(request.GetRequestURI()));
            message.Headers.Add("Authorization", auth.Authorization);
            message.Headers.Add("User-Agent", SdkVersion.UserAgent);
            message.Headers.Add("X-sdkVersion", "global-open-sdk-dotnet");
            if (extraHeaders != null)
            {
                foreach (var entry in extraHeaders)
                {
                    if (entry.Key == null || !Regex.IsMatch(entry.Key, @"\A[!#$%&'*+.^_`|~0-9A-Za-z-]+\z")
                        || entry.Value == null || entry.Value.Contains('\r') || entry.Value.Contains('\n'))
                        throw new ArgumentException("Invalid custom header", nameof(extraHeaders));
                    if (!ApiKeyAuth.ReservedHeaders.Contains(entry.Key))
                        message.Headers.Add(entry.Key, entry.Value);
                }
            }
            message.Content = new StringContent(request.BuildBody(), Encoding.UTF8, "application/json");
            try
            {
                using var response = client.SendAsync(message).ConfigureAwait(false).GetAwaiter().GetResult();
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException("AMS API response HTTP StatusCode not 200: " + response.StatusCode);
                var body = response.Content.ReadAsStringAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                return JsonSerializer.Deserialize<TAMSResponse>(body, JsonSerializerOptionsFactory.WriteNotIndented);
            }
            catch (JsonException error) { throw new JsonException(auth.Redact(error.Message)); }
            catch (HttpRequestException error) { throw new HttpRequestException(auth.Redact(error.Message)); }
        }

        public void Dispose() => client.Dispose();
    }
}
