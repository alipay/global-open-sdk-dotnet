using com.alipay.ams.api.response.dispute;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.dispute
{

public class AlipayDownloadDisputeEvidenceRequest : AMSRequest<AlipayDownloadDisputeEvidenceResponse>
    {

        public AlipayDownloadDisputeEvidenceRequest() { }

        

        public AlipayDownloadDisputeEvidenceRequest( string disputeId , DisputeEvidenceType disputeEvidenceType)
        {
            this.DisputeId = disputeId;
            this.DisputeEvidenceType = disputeEvidenceType;
        }

            public string DisputeId { get; set; }
            public DisputeEvidenceType DisputeEvidenceType { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/downloadDisputeEvidence"; } 


    }

}
