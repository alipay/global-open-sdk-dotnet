using System;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.response.auth
{
    public class AlipayInitAuthenticationResponse : AMSResponse
    {
        [JsonPropertyNameAttribute("authenticationRequestId")]
        public String AuthenticationRequestId { get; set; }
    }
}
