using com.alipay.ams.api.entities;
using com.alipay.ams.api.request;
using com.alipay.ams.api.response.auth;
using com.alipay.ams.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.request.auth
{
    public class AlipayAuthConsultRequest : AMSRequest<AlipayAuthConsultResponse>
    {
        [JsonPropertyNameAttribute("customerBelongsTo")]
        public CustomerBelongsTo CustomerBelongsTo { get; set; }
        [JsonPropertyNameAttribute("authClientId")]
        public String AuthClientId { get; set; }
        [JsonPropertyNameAttribute("authRedirectUrl")]
        public String AuthRedirectUrl { get; set; }
        [JsonPropertyNameAttribute("scopes")]
        public ScopeType[] Scopes { get; set; }
        [JsonPropertyNameAttribute("authState")]
        public String AuthState { get; set; }
        [JsonPropertyNameAttribute("terminalType")]
        public TerminalType TerminalType { get; set; }
        [JsonPropertyNameAttribute("osType")]
        public OsType OsType { get; set; }
        [JsonPropertyNameAttribute("osVersion")]
        public String OsVersion { get; set; }


        public override string BuildBody()
        {
            validate();
            return JsonSerializer.Serialize(this);

        }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/authorizations/consult";
        }

        public override void validate()
        {
            Asserts.NotNull(TerminalType, "terminalType required.");
            Asserts.NotNull(Scopes, "scopes required.");
            Asserts.NotNull(AuthClientId, "authClientId required. ");
            Asserts.NotNull(CustomerBelongsTo, "customerBelongsTo required. ");
            Asserts.NotNull(AuthState, "authState required. ");
            Asserts.NotNull(AuthRedirectUrl, "authRedirectUrl required. ");
            
        }
    }
}
