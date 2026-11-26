using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CustomerAddress
    {

        public CustomerAddress() { }

        

        public CustomerAddress( string country , string state , string city , string address , string addressDetail , string zipcode)
        {
            this.Country = country;
            this.State = state;
            this.City = city;
            this.Address = address;
            this.AddressDetail = addressDetail;
            this.Zipcode = zipcode;
        }

            public string Country { get; set; }
            public string State { get; set; }
            public string City { get; set; }
            public string Address { get; set; }
            public string AddressDetail { get; set; }
            public string Zipcode { get; set; }

        

    }

}
