using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentMethodMetaData
    {

        public PaymentMethodMetaData() { }

        

        public PaymentMethodMetaData( string recurringType)
        {
            this.RecurringType = recurringType;
        }

            public string RecurringType { get; set; }

        

    }

}
