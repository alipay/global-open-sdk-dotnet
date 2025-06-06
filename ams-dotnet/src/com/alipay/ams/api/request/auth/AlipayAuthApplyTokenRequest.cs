﻿using com.alipay.ams.api.entities;
using com.alipay.ams.api.response.auth;
using com.alipay.ams.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;


namespace com.alipay.ams.api.request.auth
{
    public class AlipayAuthApplyTokenRequest : AMSRequest<AlipayAuthApplyTokenResponse>
    {

        public GrantType GrantType { get; set; }


        public CustomerBelongsTo CustomerBelongsTo { get; set; }


        public string AuthCode { get; set; }
        
        public string RefreshToken { get; set; }
        
        public string ExtendInfo { get; set; }
        
        public string MerchantRegion { get; set; }
        

        public override string GetRequestURI()
        {
            return AntomPathConstants.AUTH_APPLY_TOKEN_PATH;
        }

        public override void validate()
        {

            Asserts.NotNull(CustomerBelongsTo, "customerBelongsTo required.");
            Asserts.NotNull(GrantType, "grantType required. ");

            switch (GrantType)
            {
                case GrantType.AUTHORIZATION_CODE:
                    Asserts.NotNull(AuthCode, "authCode required.");
                    break;

                case GrantType.REFRESH_TOKEN:
                    Asserts.NotNull(RefreshToken, "refreshToken required.");
                    break;

                default:
                    break;
            }
        }
    }
}
