using com.alipay.ams.api.entities;
using com.alipay.ams.api.response.auth;
using com.alipay.ams.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.request.auth
{
    public class AlipayAuthApplyTokenRequest : AMSRequest<AlipayAuthApplyTokenResponse>
    {
        [JsonPropertyNameAttribute("grantType")]
        public GrantType GrantType { get; set; }

        [JsonPropertyNameAttribute("customerBelongsTo")]
        public CustomerBelongsTo CustomerBelongsTo { get; set; }

        [JsonPropertyNameAttribute("authCode")]
        public String AuthCode { get; set; }

        [JsonPropertyNameAttribute("refreshToken")]
        public String RefreshToken { get; set; }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/authorizations/applyToken";
        }

        public override void validate()
        {
            Asserts.NotNull(AuthCode, "authCode required.");
            Asserts.NotNull(CustomerBelongsTo, "customerBelongsTo required.");
            Asserts.NotNull(GrantType, "grantType required. ");
        }
    }
}
