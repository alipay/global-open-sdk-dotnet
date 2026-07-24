using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Payment
    {

        public Payment() { }

        

        public Payment( string invoicePaymentId , int? attemptNo , string paymentRequestId , string paymentId , string payToRequestId , string payToId , Amount paymentAmount , string paymentOrderStatus , string paymentMethod , string errorCode , string errorMessage , string retryReason , string paymentTime , string nextRetryAt , string gmtCreate , string gmtUpdate)
        {
            this.InvoicePaymentId = invoicePaymentId;
            this.AttemptNo = attemptNo;
            this.PaymentRequestId = paymentRequestId;
            this.PaymentId = paymentId;
            this.PayToRequestId = payToRequestId;
            this.PayToId = payToId;
            this.PaymentAmount = paymentAmount;
            this.PaymentOrderStatus = paymentOrderStatus;
            this.PaymentMethod = paymentMethod;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.RetryReason = retryReason;
            this.PaymentTime = paymentTime;
            this.NextRetryAt = nextRetryAt;
            this.GmtCreate = gmtCreate;
            this.GmtUpdate = gmtUpdate;
        }

            public string InvoicePaymentId { get; set; }
            public int? AttemptNo { get; set; }
            public string PaymentRequestId { get; set; }
            public string PaymentId { get; set; }
            public string PayToRequestId { get; set; }
            public string PayToId { get; set; }
            public Amount PaymentAmount { get; set; }
            public string PaymentOrderStatus { get; set; }
            public string PaymentMethod { get; set; }
            public string ErrorCode { get; set; }
            public string ErrorMessage { get; set; }
            public string RetryReason { get; set; }
            public string PaymentTime { get; set; }
            public string NextRetryAt { get; set; }
            public string GmtCreate { get; set; }
            public string GmtUpdate { get; set; }

        

    }

}
