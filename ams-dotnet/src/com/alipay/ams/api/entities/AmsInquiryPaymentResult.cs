using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AmsInquiryPaymentResult
    {

        public AmsInquiryPaymentResult() { }

        

        public AmsInquiryPaymentResult( string paymentRequestId , string paymentId , Amount paymentAmount , string paymentStatus , string paymentResultCode , string paymentResultMessage , PaymentResultInfo paymentResultInfo , List<BatchPaymentTransaction> transactions)
        {
            this.PaymentRequestId = paymentRequestId;
            this.PaymentId = paymentId;
            this.PaymentAmount = paymentAmount;
            this.PaymentStatus = paymentStatus;
            this.PaymentResultCode = paymentResultCode;
            this.PaymentResultMessage = paymentResultMessage;
            this.PaymentResultInfo = paymentResultInfo;
            this.Transactions = transactions;
        }

            public string PaymentRequestId { get; set; }
            public string PaymentId { get; set; }
            public Amount PaymentAmount { get; set; }
            public string PaymentStatus { get; set; }
            public string PaymentResultCode { get; set; }
            public string PaymentResultMessage { get; set; }
            public PaymentResultInfo PaymentResultInfo { get; set; }
            public List<BatchPaymentTransaction> Transactions { get; set; }

        

    }

}
