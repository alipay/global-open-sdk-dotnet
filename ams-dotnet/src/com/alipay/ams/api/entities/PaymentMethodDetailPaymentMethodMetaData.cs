using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentMethodDetailPaymentMethodMetaData
    {

        public PaymentMethodDetailPaymentMethodMetaData() { }

        

        public PaymentMethodDetailPaymentMethodMetaData( string recurringType)
        {
            this.RecurringType = recurringType;
        }

            public string RecurringType { get; set; }

        

    }

}
