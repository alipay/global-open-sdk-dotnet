using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxJurisdiction
    {

        public TaxJurisdiction() { }

        

        public TaxJurisdiction( string country , string region , string county , string city , string district)
        {
            this.Country = country;
            this.Region = region;
            this.County = county;
            this.City = city;
            this.District = district;
        }

            public string Country { get; set; }
            public string Region { get; set; }
            public string County { get; set; }
            public string City { get; set; }
            public string District { get; set; }

        

    }

}
