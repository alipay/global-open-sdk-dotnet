using com.alipay.ams.api.entities;
using com.alipay.ams.api.response.auth;
using com.alipay.ams.util;
using System;
using System.Text.Json;


namespace com.alipay.ams.api.request.auth
{
    public class AlipayVerifyAuthenticationRequest : AMSRequest<AlipayVerifyAuthenticationResponse>
    {

        public AuthenticationType AuthenticationType { get; set; }


        public String AuthenticationRequestId { get; set; }


        public String AuthenticationValue { get; set; }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/users/verifyAuthentication";
        }

        public override void validate()
        {
            Asserts.NotNull(AuthenticationType, "authenticationType required.");
            Asserts.NotNull(AuthenticationRequestId, "authenticationRequestId required.");
            Asserts.NotNull(AuthenticationValue, "authenticationValue required. ");
        }
    }
}
