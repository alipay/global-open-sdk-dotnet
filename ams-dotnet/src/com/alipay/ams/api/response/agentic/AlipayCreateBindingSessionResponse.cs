using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.agentic
{

public class AlipayCreateBindingSessionResponse : AMSResponse
    {

        public AlipayCreateBindingSessionResponse() { }

        

        public AlipayCreateBindingSessionResponse( Result result , string normalUrl , string sdHash , string bindingSessionData , string bindingSessionExpiryTime)
        {
            this.Result = result;
            this.NormalUrl = normalUrl;
            this.SdHash = sdHash;
            this.BindingSessionData = bindingSessionData;
            this.BindingSessionExpiryTime = bindingSessionExpiryTime;
        }

            public Result Result { get; set; }
            public string NormalUrl { get; set; }
            public string SdHash { get; set; }
            public string BindingSessionData { get; set; }
            public string BindingSessionExpiryTime { get; set; }

        

    }

}
