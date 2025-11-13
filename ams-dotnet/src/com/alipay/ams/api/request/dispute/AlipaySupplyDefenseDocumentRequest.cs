using com.alipay.ams.api.response.dispute;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.dispute
{

public class AlipaySupplyDefenseDocumentRequest : AMSRequest<AlipaySupplyDefenseDocumentResponse>
    {

        public AlipaySupplyDefenseDocumentRequest() { }

        

        public AlipaySupplyDefenseDocumentRequest(  string  disputeId ,  string  disputeEvidence)
        {
            this.DisputeId = disputeId;
            this.DisputeEvidence = disputeEvidence;
        }

            public  string  DisputeId { get; set; }
            public  string  DisputeEvidence { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/supplyDefenseDocument"; } 


    }

}
