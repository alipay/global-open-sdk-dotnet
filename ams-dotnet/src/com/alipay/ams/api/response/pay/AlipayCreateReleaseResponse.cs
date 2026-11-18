using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayCreateReleaseResponse : AMSResponse
    {

        public AlipayCreateReleaseResponse() { }

        

        public AlipayCreateReleaseResponse( Result result , string releaseRequestId , string releaseId , string holdId , Amount releaseAmount , string releaseStatus)
        {
            this.Result = result;
            this.ReleaseRequestId = releaseRequestId;
            this.ReleaseId = releaseId;
            this.HoldId = holdId;
            this.ReleaseAmount = releaseAmount;
            this.ReleaseStatus = releaseStatus;
        }

            public Result Result { get; set; }
            public string ReleaseRequestId { get; set; }
            public string ReleaseId { get; set; }
            public string HoldId { get; set; }
            public Amount ReleaseAmount { get; set; }
            public string ReleaseStatus { get; set; }

        

    }

}
