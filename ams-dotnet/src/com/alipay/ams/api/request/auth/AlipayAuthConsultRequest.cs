using com.alipay.ams.api.entities;
using com.alipay.ams.api.request;
using com.alipay.ams.api.response.auth;
using com.alipay.ams.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;


namespace com.alipay.ams.api.request.auth
{
    public class AlipayAuthConsultRequest : AMSRequest<AlipayAuthConsultResponse>
    {

        public CustomerBelongsTo CustomerBelongsTo { get; set; }


        public String AuthClientId { get; set; }


        public String AuthRedirectUrl { get; set; }


        public ScopeType[] Scopes { get; set; }


        public String AuthState { get; set; }


        public TerminalType TerminalType { get; set; }


        public OsType OsType { get; set; }


        public String OsVersion { get; set; }

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
