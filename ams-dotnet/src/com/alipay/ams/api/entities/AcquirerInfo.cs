using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AcquirerInfo
    {

        public AcquirerInfo() { }

        

        public AcquirerInfo( string acquirerName , string referenceRequestId , string acquirerTransactionId , string acquirerMerchantId , string acquirerResultCode , string acquirerResultMessage , string acquirerMerchantName , string acquirerReasonDescription , string ptspTransactionId , string acquirerCardToken)
        {
            this.AcquirerName = acquirerName;
            this.ReferenceRequestId = referenceRequestId;
            this.AcquirerTransactionId = acquirerTransactionId;
            this.AcquirerMerchantId = acquirerMerchantId;
            this.AcquirerResultCode = acquirerResultCode;
            this.AcquirerResultMessage = acquirerResultMessage;
            this.AcquirerMerchantName = acquirerMerchantName;
            this.AcquirerReasonDescription = acquirerReasonDescription;
            this.PtspTransactionId = ptspTransactionId;
            this.AcquirerCardToken = acquirerCardToken;
        }

            public string AcquirerName { get; set; }
            public string ReferenceRequestId { get; set; }
            public string AcquirerTransactionId { get; set; }
            public string AcquirerMerchantId { get; set; }
            public string AcquirerResultCode { get; set; }
            public string AcquirerResultMessage { get; set; }
            public string AcquirerMerchantName { get; set; }
            public string AcquirerReasonDescription { get; set; }
            public string PtspTransactionId { get; set; }
            public string AcquirerCardToken { get; set; }

        

    }

}
