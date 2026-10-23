using com.alipay.ams.api.response.dispute;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.dispute
{

public class AlipaySupplyEvidenceRequest : AMSRequest<AlipaySupplyEvidenceResponse>
    {

        public AlipaySupplyEvidenceRequest() { }

        

        public AlipaySupplyEvidenceRequest( string disputeId , Dictionary<string, Object> evidenceContent)
        {
            this.DisputeId = disputeId;
            this.EvidenceContent = evidenceContent;
        }

            public string DisputeId { get; set; }
            public Dictionary<string, Object> EvidenceContent { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/supplyEvidence"; } 


    }

}
