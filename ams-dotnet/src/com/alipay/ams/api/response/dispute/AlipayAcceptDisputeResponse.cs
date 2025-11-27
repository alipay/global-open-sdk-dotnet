using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.dispute
{

public class AlipayAcceptDisputeResponse : AMSResponse
    {

        public AlipayAcceptDisputeResponse() { }

        

        public AlipayAcceptDisputeResponse( Result result , string disputeId , string disputeResolutionTime)
        {
            this.Result = result;
            this.DisputeId = disputeId;
            this.DisputeResolutionTime = disputeResolutionTime;
        }

            public Result Result { get; set; }
            public string DisputeId { get; set; }
            public string DisputeResolutionTime { get; set; }

        

    }

}
