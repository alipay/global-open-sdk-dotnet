using System.Text.Json.Serialization;

namespace com.alipay.ams.api.response.auth
{
    public class AlipayVerifyAuthenticationResponse : AMSResponse
    {
        [JsonPropertyNameAttribute("isPassed")]
        public bool IsPassed { get; set; }
    }
}
