using System;
using System.Collections.Generic;
using System.Text;


namespace com.alipay.ams.api.entities
{
    public class PaymentMethod
    {
        public PaymentMethod(String paymentMethodType)
        {
            this.PaymentMethodType = paymentMethodType;
        }


        public String PaymentMethodType { get; set; }

        public String PaymentMethodId { get; set; }

        public String PaymentMethodMetaData { get; set; }

        public String CustomerId { get; set; }
    }
}
