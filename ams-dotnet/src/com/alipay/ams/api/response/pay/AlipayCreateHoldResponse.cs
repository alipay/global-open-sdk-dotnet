using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayCreateHoldResponse : AMSResponse
    {

        public AlipayCreateHoldResponse() { }

        

        public AlipayCreateHoldResponse( Result result , string holdRequestId , string holdId , Amount holdAmount , string releaseTime , string holdStatus)
        {
            this.Result = result;
            this.HoldRequestId = holdRequestId;
            this.HoldId = holdId;
            this.HoldAmount = holdAmount;
            this.ReleaseTime = releaseTime;
            this.HoldStatus = holdStatus;
        }

            public Result Result { get; set; }
            public string HoldRequestId { get; set; }
            public string HoldId { get; set; }
            public Amount HoldAmount { get; set; }
            public string ReleaseTime { get; set; }
            public string HoldStatus { get; set; }

        

    }

}
