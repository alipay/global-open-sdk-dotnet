using com.alipay.ams.api.entities;
using com.alipay.ams.api.response.auth;
using com.alipay.ams.util;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.request.auth
{
    public class AlipayVerifyAuthenticationRequest : AMSRequest<AlipayVerifyAuthenticationResponse>
    {
        [JsonPropertyNameAttribute("authenticationType")]
        public AuthenticationType AuthenticationType { get; set; }

        [JsonPropertyNameAttribute("authenticationType")]
        public String AuthenticationRequestId { get; set; }

        [JsonPropertyNameAttribute("authenticationType")]
        public String AuthenticationValue { get; set; }

        public override string BuildBody()
        {
            validate();
            return JsonSerializer.Serialize(this);
        }

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
