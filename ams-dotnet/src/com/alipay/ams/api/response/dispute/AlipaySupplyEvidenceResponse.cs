using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.dispute
{

public class AlipaySupplyEvidenceResponse : AMSResponse
    {

        public AlipaySupplyEvidenceResponse() { }

        

        public AlipaySupplyEvidenceResponse( Result result , string disputeId , List<DisputeEvidenceResult> evidenceResults)
        {
            this.Result = result;
            this.DisputeId = disputeId;
            this.EvidenceResults = evidenceResults;
        }

            public Result Result { get; set; }
            public string DisputeId { get; set; }
            public List<DisputeEvidenceResult> EvidenceResults { get; set; }

        

    }

}
