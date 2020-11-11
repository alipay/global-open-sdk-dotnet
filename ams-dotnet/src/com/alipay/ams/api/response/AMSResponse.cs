using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.response
{
    public abstract class AMSResponse
    {
        [JsonPropertyNameAttribute("result")]
        public Result Result { get; set; }

        protected JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            IgnoreNullValues = true,
            WriteIndented = true
        };

        public AMSResponse()
        {
            options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
        }

        public static TAMSResponse ParseResponse<TAMSResponse>(HttpResponseMessage ret, string requestURI, string clientId, string alipayPublicKey)
        {
            switch(ret.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    {
                        // 1. Extract response body and headers.
                        var responseBody = ret.Content.ReadAsStringAsync().ConfigureAwait(false).GetAwaiter().GetResult();

                        // These two headers must be present.
                        Asserts.AssertTrue(ret.Headers.Contains("response-time"), "response-time missing in the response header.");
                        Asserts.AssertTrue(ret.Headers.Contains("signature"), "signature missing in the response header. responseBody = \n\t"+ responseBody);

                        string responseTime = ret.Headers.GetValues("response-time").FirstOrDefault();
                        string signature = ret.Headers.GetValues("signature").FirstOrDefault();

                        string signatureToBeVerified = signature.Split("signature=")[1];

                        // 2. Now we do signature verification.
                        bool signatureMatch = SignatureUtil.verify(requestURI, clientId, responseTime, alipayPublicKey, responseBody, signatureToBeVerified);

                        if(! signatureMatch)
                        {
                            throw new InvalidOperationException("AMS API response signature invalid: clientId = " + clientId + ", signatureToBeVerified = " + signatureToBeVerified);
                        }


                        //3. So far so good. continue to parse body content.
                        return JsonSerializer.Deserialize<TAMSResponse>(responseBody);
                        
                    }

                default:
                    throw new HttpRequestException("AMS API response HTTP StatusCode not 200: " + ret.StatusCode.ToString()+". Check your gatewayUrl and requestURI settings.");
            }            
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, this.GetType(), options);
        }

    }
}
