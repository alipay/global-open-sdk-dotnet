using com.alipay.ams.api.response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.response.auth
{
    public class AlipayAuthConsultResponse : AMSResponse
    {
        [JsonPropertyNameAttribute("authUrl")]
        public String AuthUrl { get; set; }
    }
}
