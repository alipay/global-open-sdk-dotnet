using com.alipay.ams.api.entities;
using com.alipay.ams.api.response.auth;
using com.alipay.ams.util;
using System;
using System.Text.Json;


namespace com.alipay.ams.api.request.auth
{
    public class AlipayInitAuthenticationRequest : AMSRequest<AlipayInitAuthenticationResponse>
    {

        public AuthenticationType AuthenticationType { get; set; }


        public String AuthenticationRequestId { get; set; }


        public AuthenticationChannelType AuthenticationChannelType { get; set; }


        public UserIdentityType UserIdentityType { get; set; }


        public String UserIdentityValue { get; set; }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/users/initAuthentication";
        }

        public override void validate()
        {
            Asserts.NotNull(AuthenticationType, "authenticationType required.");
            Asserts.NotNull(AuthenticationRequestId, "authenticationRequestId required.");
            Asserts.NotNull(AuthenticationChannelType, "authenticationChannelType required. ");
            Asserts.NotNull(UserIdentityType, "userIdentityType required. ");
            Asserts.NotNull(UserIdentityValue, "userIdentityValue required. ");
        }
    }
}
