using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.response.auth
{
    public class AlipayAuthApplyTokenResponse : AMSResponse
    {
        [JsonPropertyNameAttribute("accessToken")]
        public String AccessToken { get; set; }
        [JsonPropertyNameAttribute("accessTokenExpiryTime")]
        public String AccessTokenExpiryTime { get; set; }
        [JsonPropertyNameAttribute("refreshToken")]
        public String RefreshToken { get; set; }
        [JsonPropertyNameAttribute("refreshTokenExpiryTime")]
        public String RefreshTokenExpiryTime { get; set; }
    }
}
