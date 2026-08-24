using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxCalculatedExemptionJurisdiction
    {

        public TaxCalculatedExemptionJurisdiction() { }

        

        public TaxCalculatedExemptionJurisdiction( string country , string region , string city , string effectiveFrom)
        {
            this.Country = country;
            this.Region = region;
            this.City = city;
            this.EffectiveFrom = effectiveFrom;
        }

            public string Country { get; set; }
            public string Region { get; set; }
            public string City { get; set; }
            public string EffectiveFrom { get; set; }

        

    }

}
