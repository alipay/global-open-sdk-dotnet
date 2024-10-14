using com.alipay.ams.api.request;
using com.alipay.ams.api.response.auth;
using com.alipay.ams.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using com.alipay.ams.api.entities;


namespace com.alipay.ams.api.request.auth
{
    public class AlipayAuthRevokeTokenRequest : AMSRequest<AlipayAuthRevokeTokenResponse>
    {

        public string AccessToken { get; set; }
        
        public string ExtendInfo { get; set; }

        public override string GetRequestURI()
        {
            return AntomPathConstants.AUTH_REVOKE_PATH;
        }

        public override void validate()
        {
            Asserts.NotNull(AccessToken, "accessToken required.");
        }
    }
}
