using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.dispute
{

public class AlipayDownloadDisputeEvidenceResponse : AMSResponse
    {

        public AlipayDownloadDisputeEvidenceResponse() { }

        

        public AlipayDownloadDisputeEvidenceResponse( Result result , string disputeEvidence , DisputeEvidenceFormatType disputeEvidenceFormat)
        {
            this.Result = result;
            this.DisputeEvidence = disputeEvidence;
            this.DisputeEvidenceFormat = disputeEvidenceFormat;
        }

            public Result Result { get; set; }
            public string DisputeEvidence { get; set; }
            public DisputeEvidenceFormatType DisputeEvidenceFormat { get; set; }

        

    }

}
