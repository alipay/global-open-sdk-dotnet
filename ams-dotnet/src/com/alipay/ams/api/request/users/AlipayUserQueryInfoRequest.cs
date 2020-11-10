using com.alipay.ams.api.response.auth;
using com.alipay.ams.util;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.request.auth
{
    public class AlipayUserQueryInfoRequest : AMSRequest<AlipayUserQueryInfoResponse>
    {
        [JsonPropertyNameAttribute("accessToken")]
        public String AccessToken { get; set; }

        public override string BuildBody()
        {
            validate();
            return JsonSerializer.Serialize(this);
        }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/users/inquiryUserInfo";
        }

        public override void validate()
        {
            Asserts.NotNull(AccessToken, "accessToken required.");
        }
    }
}
