using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxAddress
    {

        public TaxAddress() { }

        

        public TaxAddress( string country , string region , string county , string city , string district , string line1 , string line2 , string postalCode)
        {
            this.Country = country;
            this.Region = region;
            this.County = county;
            this.City = city;
            this.District = district;
            this.Line1 = line1;
            this.Line2 = line2;
            this.PostalCode = postalCode;
        }

            public string Country { get; set; }
            public string Region { get; set; }
            public string County { get; set; }
            public string City { get; set; }
            public string District { get; set; }
            public string Line1 { get; set; }
            public string Line2 { get; set; }
            public string PostalCode { get; set; }

        

    }

}
