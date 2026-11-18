using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BuyerTaxId
    {

        public BuyerTaxId() { }

        

        public BuyerTaxId( string country , string region , string value)
        {
            this.Country = country;
            this.Region = region;
            this.Value = value;
        }

            public string Country { get; set; }
            public string Region { get; set; }
            public string Value { get; set; }

        

    }

}
