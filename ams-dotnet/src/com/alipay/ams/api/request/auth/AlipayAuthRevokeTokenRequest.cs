using com.alipay.ams.api.response.auth;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.auth
{

public class AlipayAuthRevokeTokenRequest : AMSRequest<AlipayAuthRevokeTokenResponse>
    {

        public AlipayAuthRevokeTokenRequest() { }

        

        public AlipayAuthRevokeTokenRequest( string accessToken , string extendInfo)
        {
            this.AccessToken = accessToken;
            this.ExtendInfo = extendInfo;
        }

            public string AccessToken { get; set; }
            public string ExtendInfo { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/authorizations/revoke"; } 


    }

}
