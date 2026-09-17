using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using com.alipay.ams.api.request;
using com.alipay.ams.api.response;
using System.Text.Json;
using com.alipay.ams.util;

namespace com.alipay.ams.api
{
    public class DefaultAlipayClient
    {
        private readonly ApiKeyAuth apiKeyAuth;

        public DefaultAlipayClient(string gatewayUrl, string apiKey)
        {
            apiKeyAuth = new ApiKeyAuth(gatewayUrl, apiKey);
            GatewayUrl = apiKeyAuth.GatewayUrl;
            ClientId = apiKeyAuth.ClientId;
            client.Dispose();
            // Keep platform certificate and hostname verification; do not forward Bearer on redirects.
            client = new HttpClient(new HttpClientHandler { AllowAutoRedirect = false });
        }
        private static readonly HashSet<string> ReservedHeaders = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        { "Signature", "client-id", "Request-Time", "Content-Type", "agent-token", "User-Agent", "X-sdkVersion" };

        public DefaultAlipayClient(
            string gatewayUrl,
            string clientId,
            string merchantPrivateKey,
            string alipayPublicKey,
            string agentToken = null)
        {
            this.AlipayPublicKey = alipayPublicKey;
            this.ClientId = clientId;
            this.AgentToken = agentToken;
            this.GatewayUrl = gatewayUrl;
            this.MerchantPrivateKey = merchantPrivateKey;
        }

        public string GatewayUrl { get; }
        public string ClientId { get; }
        public string AgentToken { get; }
        public string MerchantPrivateKey { get; }
        public string AlipayPublicKey { get; }
        private string UploadGatewayUrl { get; set; }

        private HttpClient client = new System.Net.Http.HttpClient();

        public void SetUploadGatewayUrl(string uploadGatewayUrl)
        {
            UploadGatewayUrl = UploadGatewayResolver.NormalizeExplicit(uploadGatewayUrl);
        }

        /// <summary>
        /// Uploads an SDK-provided file request through the OpenApiV2File transport.
        /// </summary>
        public TAMSResponse UploadFile<TAMSResponse>(AMSFileRequest<TAMSResponse> request)
            where TAMSResponse : AMSResponse
        {
            if (apiKeyAuth != null) throw new InvalidOperationException("File upload does not support API Key authentication");
            return FileUploadExecutor.Execute(this, UploadGatewayUrl, request);
        }

        public  TAMSResponse Execute<TAMSResponse>(request.AMSRequest<TAMSResponse> request)
            where TAMSResponse : AMSResponse
        {
            if (apiKeyAuth != null) return ExecuteApiKey(request, null);
            var requestUrl = BuildRequestUrl(request.GetRequestURI());

            var requestMessage = new System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Post, requestUrl );

            var body = request.BuildBody();
            var headers = request.BuildRequestHeader(this.ClientId,this.AgentToken,this.MerchantPrivateKey);


            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            requestMessage.Content = new ByteArrayContent(Encoding.UTF8.GetBytes(body));
            requestMessage.Content.Headers.Add("Content-Type", "application/json; charset=UTF-8");


            var ret = client.SendAsync(requestMessage).ConfigureAwait(false).GetAwaiter().GetResult(); ;
            

            return AMSResponse.ParseResponse<TAMSResponse>(ret, BuildRequestUri(request.GetRequestURI()), this.ClientId,this.AlipayPublicKey);
        }

        public  TAMSResponse ExecuteWithHeaders<TAMSResponse>(request.AMSRequest<TAMSResponse> request, Dictionary<string, string> extraHeaders)
            where TAMSResponse : AMSResponse
        {
            if (RequestTransportResolver.RequiresSessionHttp2(
                System.Net.Http.HttpMethod.Post.Method,
                request.GetRequestURI()))
            {
                return SessionHttp2Executor.Execute(this.GatewayUrl, request, extraHeaders);
            }

            if (apiKeyAuth != null) return ExecuteApiKey(request, extraHeaders);

            var requestUrl = BuildRequestUrl(request.GetRequestURI());

            var requestMessage = new System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Post, requestUrl );

            var body = request.BuildBody();
            var headers = request.BuildRequestHeader(this.ClientId,this.AgentToken,this.MerchantPrivateKey);


            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            if (extraHeaders != null)
            {
                foreach (var entry in extraHeaders)
                {
                    if (entry.Key == null)
                    {
                        continue;
                    }
                    if (!ReservedHeaders.Contains(entry.Key))
                    {
                        requestMessage.Headers.Add(entry.Key, entry.Value);
                    }
                }
            }

            requestMessage.Content = new ByteArrayContent(Encoding.UTF8.GetBytes(body));
            requestMessage.Content.Headers.Add("Content-Type", "application/json; charset=UTF-8");


            var ret = client.SendAsync(requestMessage).ConfigureAwait(false).GetAwaiter().GetResult(); ;


            return AMSResponse.ParseResponse<TAMSResponse>(ret, BuildRequestUri(request.GetRequestURI()), this.ClientId,this.AlipayPublicKey);
        }
        
        public string BuildRequestUrl(string originPath)
        {
            if (apiKeyAuth != null) return apiKeyAuth.GatewayUrl + apiKeyAuth.Path(originPath);

            if (ClientId != null
                && ClientId.StartsWith("SANDBOX_", StringComparison.Ordinal)
                && !SandboxPathResolver.ShouldUseProductionPathInSandbox(originPath))
            {
                originPath = originPath.Replace("/ams/api", "/ams/sandbox/api");
            }

            var baseUri = new Uri(this.GatewayUrl, UriKind.Absolute);
            var fullUri = new Uri(baseUri, originPath);
            return fullUri.ToString();
        }
        
        public string BuildRequestUri(string originPath)
        {
            if (apiKeyAuth != null) return apiKeyAuth.Path(originPath);

            if (ClientId != null
                && ClientId.StartsWith("SANDBOX_", StringComparison.Ordinal)
                && !SandboxPathResolver.ShouldUseProductionPathInSandbox(originPath))
            {
                originPath = originPath.Replace("/ams/api", "/ams/sandbox/api");
            }
            return originPath;
        } 

        private TAMSResponse ExecuteApiKey<TAMSResponse>(AMSRequest<TAMSResponse> request, Dictionary<string, string> extraHeaders)
            where TAMSResponse : AMSResponse
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            using (var message = new HttpRequestMessage(System.Net.Http.HttpMethod.Post, BuildRequestUrl(request.GetRequestURI())))
            {
                if (extraHeaders != null)
                {
                    foreach (var entry in extraHeaders)
                    {
                        if (string.IsNullOrWhiteSpace(entry.Key) || ReservedHeaders.Contains(entry.Key)
                            || string.Equals(entry.Key, "Authorization", StringComparison.OrdinalIgnoreCase)
                            || string.Equals(entry.Key, "Key-Version", StringComparison.OrdinalIgnoreCase)
                            || string.Equals(entry.Key, "keyVersion", StringComparison.OrdinalIgnoreCase)
                            || string.Equals(entry.Key, "Host", StringComparison.OrdinalIgnoreCase)) continue;
                        message.Headers.Add(entry.Key, entry.Value);
                    }
                }
                message.Headers.Add("Authorization", apiKeyAuth.Authorization);
                message.Headers.Add("User-Agent", SdkVersion.UserAgent);
                message.Headers.Add("X-sdkVersion", "ams-dotnet.20201113");
                message.Content = new StringContent(request.BuildBody(), Encoding.UTF8, "application/json");
                using (var response = client.SendAsync(message).ConfigureAwait(false).GetAwaiter().GetResult())
                {
                    var body = response.Content.ReadAsStringAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                        throw new HttpRequestException("API Key HTTP status " + (int)response.StatusCode + ": " + apiKeyAuth.Redact(body));
                    TAMSResponse result;
                    try
                    {
                        using (var json = JsonDocument.Parse(body))
                        {
                            JsonElement wireResult;
                            if (json.RootElement.ValueKind != JsonValueKind.Object
                                || !json.RootElement.TryGetProperty("result", out wireResult)
                                || wireResult.ValueKind != JsonValueKind.Object)
                                throw new InvalidOperationException("API Key response result field is null");
                        }
                        result = JsonSerializer.Deserialize<TAMSResponse>(body, JsonSerializerOptionsFactory.WriteNotIndented);
                    }
                    catch (JsonException) { throw new InvalidOperationException("API Key response is not valid JSON for the response type"); }
                    if (result == null) throw new InvalidOperationException("API Key response is null");
                    return result;
                }
            }
        }
    }
}
