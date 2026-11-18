using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxExemptionJurisdiction
    {

        public TaxExemptionJurisdiction() { }

        

        public TaxExemptionJurisdiction( string country , string region , string city)
        {
            this.Country = country;
            this.Region = region;
            this.City = city;
        }

            public string Country { get; set; }
            public string Region { get; set; }
            public string City { get; set; }

        

    }

}
