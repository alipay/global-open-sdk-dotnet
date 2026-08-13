using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InvoiceAddress
    {

        public InvoiceAddress() { }

        

        public InvoiceAddress( string country , string state , string city , string address1 , string address2 , string postalCode)
        {
            this.Country = country;
            this.State = state;
            this.City = city;
            this.Address1 = address1;
            this.Address2 = address2;
            this.PostalCode = postalCode;
        }

            public string Country { get; set; }
            public string State { get; set; }
            public string City { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string PostalCode { get; set; }

        

    }

}
