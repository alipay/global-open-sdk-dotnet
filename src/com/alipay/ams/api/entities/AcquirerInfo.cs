    
namespace com.alipay.ams.api.entities
{

public class AcquirerInfo
    {

        public AcquirerInfo() { }

        public AcquirerInfo( string acquirerName , string referenceRequestId , string acquirerTransactionId , string acquirerMerchantId , string acquirerResultCode , string acquirerResultMessage)
        {
            this.AcquirerName = acquirerName;
            this.ReferenceRequestId = referenceRequestId;
            this.AcquirerTransactionId = acquirerTransactionId;
            this.AcquirerMerchantId = acquirerMerchantId;
            this.AcquirerResultCode = acquirerResultCode;
            this.AcquirerResultMessage = acquirerResultMessage;
        }

            public string AcquirerName { get; set; }
            public string ReferenceRequestId { get; set; }
            public string AcquirerTransactionId { get; set; }
            public string AcquirerMerchantId { get; set; }
            public string AcquirerResultCode { get; set; }
            public string AcquirerResultMessage { get; set; }

        

    }

}
