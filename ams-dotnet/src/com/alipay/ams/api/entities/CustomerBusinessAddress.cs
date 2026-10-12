using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CustomerBusinessAddress
    {

        public CustomerBusinessAddress() { }

        

        public CustomerBusinessAddress( string country , string state , string city , string address , string zipcode)
        {
            this.Country = country;
            this.State = state;
            this.City = city;
            this.Address = address;
            this.Zipcode = zipcode;
        }

            public string Country { get; set; }
            public string State { get; set; }
            public string City { get; set; }
            public string Address { get; set; }
            public string Zipcode { get; set; }

        

    }

}
