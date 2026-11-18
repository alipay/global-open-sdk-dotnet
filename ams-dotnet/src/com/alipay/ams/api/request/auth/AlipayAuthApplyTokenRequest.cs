using com.alipay.ams.api.response.auth;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.auth
{

public class AlipayAuthApplyTokenRequest : AMSRequest<AlipayAuthApplyTokenResponse>
    {

        public AlipayAuthApplyTokenRequest() { }

        

        public AlipayAuthApplyTokenRequest( string merchantAccountId , GrantType grantType , CustomerBelongsTo customerBelongsTo , string authCode , string refreshToken , string extendInfo , string merchantRegion)
        {
            this.MerchantAccountId = merchantAccountId;
            this.GrantType = grantType;
            this.CustomerBelongsTo = customerBelongsTo;
            this.AuthCode = authCode;
            this.RefreshToken = refreshToken;
            this.ExtendInfo = extendInfo;
            this.MerchantRegion = merchantRegion;
        }

            public string MerchantAccountId { get; set; }
            public GrantType GrantType { get; set; }
            public CustomerBelongsTo CustomerBelongsTo { get; set; }
            public string AuthCode { get; set; }
            public string RefreshToken { get; set; }
            public string ExtendInfo { get; set; }
            public string MerchantRegion { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/authorizations/applyToken"; } 


    }

}
