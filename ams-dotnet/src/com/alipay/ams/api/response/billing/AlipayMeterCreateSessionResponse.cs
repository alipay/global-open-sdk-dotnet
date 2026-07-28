using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayMeterCreateSessionResponse : AMSResponse
    {

        public AlipayMeterCreateSessionResponse() { }

        

        public AlipayMeterCreateSessionResponse( Result result , string sessionId , string sessionExpiryTime)
        {
            this.Result = result;
            this.SessionId = sessionId;
            this.SessionExpiryTime = sessionExpiryTime;
        }

            public Result Result { get; set; }
            public string SessionId { get; set; }
            public string SessionExpiryTime { get; set; }

        

    }

}
