using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class SubscriptionTransaction
    {

        public SubscriptionTransaction() { }

        

        public SubscriptionTransaction( string paymentId , string status , int? phaseNo , PaymentMethod paymentMethod , Amount paymentAmount , string paymentTime , string disputeId)
        {
            this.PaymentId = paymentId;
            this.Status = status;
            this.PhaseNo = phaseNo;
            this.PaymentMethod = paymentMethod;
            this.PaymentAmount = paymentAmount;
            this.PaymentTime = paymentTime;
            this.DisputeId = disputeId;
        }

            public string PaymentId { get; set; }
            public string Status { get; set; }
            public int? PhaseNo { get; set; }
            public PaymentMethod PaymentMethod { get; set; }
            public Amount PaymentAmount { get; set; }
            public string PaymentTime { get; set; }
            public string DisputeId { get; set; }

        

    }

}
