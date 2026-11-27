using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentSessionInvoiceCreation
    {

        public PaymentSessionInvoiceCreation() { }

        

        public PaymentSessionInvoiceCreation( string enabled)
        {
            this.Enabled = enabled;
        }

            public string Enabled { get; set; }

        

    }

}
