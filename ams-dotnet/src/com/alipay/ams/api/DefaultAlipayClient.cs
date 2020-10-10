using System;
using System.Net.Http;
using System.Text;
using com.alipay.ams.api.response;

namespace com.alipay.ams.api
{
    public class DefaultAlipayClient
    {
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

        private HttpClient client = new System.Net.Http.HttpClient();

        public  TAMSResponse Execute<TAMSResponse>(request.AMSRequest<TAMSResponse> request)
            where TAMSResponse : AMSResponse
        {
            
            var requestMessage = new System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Post, this.GatewayUrl+ request.GetRequestURI());

            var body = request.BuildBody();
            var headers = request.BuildRequestHeader(this.ClientId,this.AgentToken,this.MerchantPrivateKey);


            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            Console.WriteLine("Request --> " + body);
            requestMessage.Content = new ByteArrayContent(Encoding.UTF8.GetBytes(body));
            requestMessage.Content.Headers.Add("Content-Type", "application/json; charset=UTF-8");


            var ret = client.SendAsync(requestMessage).ConfigureAwait(false).GetAwaiter().GetResult(); ;

            return AMSResponse.ParseResponse<TAMSResponse>(ret, request.GetRequestURI(), this.ClientId,this.AlipayPublicKey);
        }
    }
}
