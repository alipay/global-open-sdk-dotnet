using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxTransaction
    {

        public TaxTransaction() { }

        

        public TaxTransaction( string taxTransactionId , string taxCalculationId , string type , Amount taxAmount , string status , string failureReason , string taxDate , string postedAt , string referencePaymentId , string referenceRefundId)
        {
            this.TaxTransactionId = taxTransactionId;
            this.TaxCalculationId = taxCalculationId;
            this.Type = type;
            this.TaxAmount = taxAmount;
            this.Status = status;
            this.FailureReason = failureReason;
            this.TaxDate = taxDate;
            this.PostedAt = postedAt;
            this.ReferencePaymentId = referencePaymentId;
            this.ReferenceRefundId = referenceRefundId;
        }

            public string TaxTransactionId { get; set; }
            public string TaxCalculationId { get; set; }
            public string Type { get; set; }
            public Amount TaxAmount { get; set; }
            public string Status { get; set; }
            public string FailureReason { get; set; }
            public string TaxDate { get; set; }
            public string PostedAt { get; set; }
            public string ReferencePaymentId { get; set; }
            public string ReferenceRefundId { get; set; }

        

    }

}
