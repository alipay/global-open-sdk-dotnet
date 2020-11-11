using com.alipay.ams.api.response.auth;
using com.alipay.ams.util;
using System;
using System.Text.Json;


namespace com.alipay.ams.api.request.auth
{
    public class AlipayUserQueryInfoRequest : AMSRequest<AlipayUserQueryInfoResponse>
    {

        public String AccessToken { get; set; }

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
