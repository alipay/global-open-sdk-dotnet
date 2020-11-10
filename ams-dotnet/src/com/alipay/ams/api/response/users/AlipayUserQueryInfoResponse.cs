using System;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.response.auth
{
    public class AlipayUserQueryInfoResponse : AMSResponse
    {
        [JsonPropertyNameAttribute("userId")]
        public String UserId { get; set; }

        [JsonPropertyNameAttribute("userLoginId")]
        public String UserLoginId { get; set; }

        [JsonPropertyNameAttribute("hashUserLoginId")]
        public String HashUserLoginId { get; set; }
    }
}
