using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentEvaluation
    {

        public PaymentEvaluation() { }

        

        public PaymentEvaluation( PaymentMethod[] paymentMethods)
        {
            this.PaymentMethods = paymentMethods;
        }

            public PaymentMethod[] PaymentMethods { get; set; }

        

    }

}
