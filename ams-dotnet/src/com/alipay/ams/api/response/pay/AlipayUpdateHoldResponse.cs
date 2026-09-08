using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayUpdateHoldResponse : AMSResponse
    {

        public AlipayUpdateHoldResponse() { }

        

        public AlipayUpdateHoldResponse( Result result , string holdId , string releaseTime)
        {
            this.Result = result;
            this.HoldId = holdId;
            this.ReleaseTime = releaseTime;
        }

            public Result Result { get; set; }
            public string HoldId { get; set; }
            public string ReleaseTime { get; set; }

        

    }

}
