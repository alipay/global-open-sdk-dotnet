using com.alipay.ams.api.request;
using com.alipay.ams.api.response.auth;
using com.alipay.ams.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;


namespace com.alipay.ams.api.request.auth
{
    public class AlipayAuthRevokeTokenRequest : AMSRequest<AlipayAuthRevokeTokenResponse>
    {

        public String AccessToken { get; set; }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/authorizations/revoke";
        }

        public override void validate()
        {
            Asserts.NotNull(AccessToken, "accessToken required.");
        }
    }
}
