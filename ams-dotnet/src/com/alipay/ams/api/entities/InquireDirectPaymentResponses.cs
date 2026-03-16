using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InquireDirectPaymentResponses
    {

        public InquireDirectPaymentResponses() { }

        

        public InquireDirectPaymentResponses( TransactionStatusType paymentStatus , string paymentResultMessage , string paymentResultCode , string paymentId , string paymentRequestId , PaymentMethod payToMethod , Amount paymentAmount , Amount payToAmount , string paymentTime , Result result)
        {
            this.PaymentStatus = paymentStatus;
            this.PaymentResultMessage = paymentResultMessage;
            this.PaymentResultCode = paymentResultCode;
            this.PaymentId = paymentId;
            this.PaymentRequestId = paymentRequestId;
            this.PayToMethod = payToMethod;
            this.PaymentAmount = paymentAmount;
            this.PayToAmount = payToAmount;
            this.PaymentTime = paymentTime;
            this.Result = result;
        }

            public TransactionStatusType PaymentStatus { get; set; }
            public string PaymentResultMessage { get; set; }
            public string PaymentResultCode { get; set; }
            public string PaymentId { get; set; }
            public string PaymentRequestId { get; set; }
            public PaymentMethod PayToMethod { get; set; }
            public Amount PaymentAmount { get; set; }
            public Amount PayToAmount { get; set; }
            public string PaymentTime { get; set; }
            public Result Result { get; set; }

        

    }

}
