using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxCalculatedTaxId
    {

        public TaxCalculatedTaxId() { }

        

        public TaxCalculatedTaxId( string value , string country , string region , string name)
        {
            this.Value = value;
            this.Country = country;
            this.Region = region;
            this.Name = name;
        }

            public string Value { get; set; }
            public string Country { get; set; }
            public string Region { get; set; }
            public string Name { get; set; }

        

    }

}
