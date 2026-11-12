using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.dispute
{

public class AlipaySupplyEvidenceResponse : AMSResponse
    {

        public AlipaySupplyEvidenceResponse() { }

        

        public AlipaySupplyEvidenceResponse( Result result , string disputeId , List<SupplyEvidenceResult> evidenceResults)
        {
            this.Result = result;
            this.DisputeId = disputeId;
            this.EvidenceResults = evidenceResults;
        }

            public string DisputeId { get; set; }
            public List<SupplyEvidenceResult> EvidenceResults { get; set; }

        

    }

}
