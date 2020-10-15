using System;
using System.Collections.Generic;
using com.alipay.ams.api.response;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public abstract class AMSRequest<TAMSResponse>
        where TAMSResponse:AMSResponse
    {
        public abstract string GetRequestURI();

        public abstract String BuildBody();

        public abstract void validate();

        public Dictionary<string, string> BuildRequestHeader(string clientId, string agentToken, string privateKey)
        {
            var headers = new Dictionary<string, string>();

            var requestTime = DateTime.UtcNow.ToString("o"); 
            headers.Add("client-id", clientId);
            headers.Add("signature", "algorithm=RSA256,keyVersion=1,signature=" + SignatureUtil.sign(GetRequestURI(), clientId, requestTime, privateKey, BuildBody()));

            if(agentToken != null)
            {
                headers.Add("Agent-Token", agentToken);
            }
            

            headers.Add("request-time", requestTime);
            headers.Add("X-sdkVersion", "ams-dotnet.20200929");

            Dictionary<String, String> extraHeaders = GetExtraHeaders();
            if (extraHeaders != null)
            {
                foreach(var extHeader in extraHeaders)
                {
                    headers.Add(extHeader.Key, extHeader.Value);
                }
            }

            return headers;
        }

        protected Dictionary<string, string> GetExtraHeaders() {
            return null;
        }
    }

    
}
