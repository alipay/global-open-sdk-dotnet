using com.alipay.ams.api.response.dispute;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.dispute
{

public class AlipayAcceptDisputeRequest : AMSRequest<AlipayAcceptDisputeResponse>
    {

        public AlipayAcceptDisputeRequest() { }

        

        public AlipayAcceptDisputeRequest( string disputeId)
        {
            this.DisputeId = disputeId;
        }

            public string DisputeId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/acceptDispute"; } 


    }

}
