using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class DisputeEvidenceResult
    {

        public DisputeEvidenceResult() { }

        

        public DisputeEvidenceResult( string evidenceTag , string success , string resultCode , string failedFieldPath)
        {
            this.EvidenceTag = evidenceTag;
            this.Success = success;
            this.ResultCode = resultCode;
            this.FailedFieldPath = failedFieldPath;
        }

            public string EvidenceTag { get; set; }
            public string Success { get; set; }
            public string ResultCode { get; set; }
            public string FailedFieldPath { get; set; }

        

    }

}
