using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.agentic
{

public class AlipayCreateAuthenticationSessionResponse : AMSResponse
    {

        public AlipayCreateAuthenticationSessionResponse() { }

        

        public AlipayCreateAuthenticationSessionResponse( Result result , string normalUrl , string sdHash , string authenticationSessionExpiryTime)
        {
            this.Result = result;
            this.NormalUrl = normalUrl;
            this.SdHash = sdHash;
            this.AuthenticationSessionExpiryTime = authenticationSessionExpiryTime;
        }

            public Result Result { get; set; }
            public string NormalUrl { get; set; }
            public string SdHash { get; set; }
            public string AuthenticationSessionExpiryTime { get; set; }

        

    }

}
