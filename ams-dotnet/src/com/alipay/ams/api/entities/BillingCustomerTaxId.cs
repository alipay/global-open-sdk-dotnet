using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingCustomerTaxId
    {

        public BillingCustomerTaxId() { }

        

        public BillingCustomerTaxId( string value , string country , string region , string type)
        {
            this.Value = value;
            this.Country = country;
            this.Region = region;
            this.Type = type;
        }

            public string Value { get; set; }
            public string Country { get; set; }
            public string Region { get; set; }
            public string Type { get; set; }

        

    }

}
