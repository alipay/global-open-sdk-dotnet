using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PayInvoiceCreation
    {

        public PayInvoiceCreation() { }

        

        public PayInvoiceCreation( string enabled)
        {
            this.Enabled = enabled;
        }

            public string Enabled { get; set; }

        

    }

}
