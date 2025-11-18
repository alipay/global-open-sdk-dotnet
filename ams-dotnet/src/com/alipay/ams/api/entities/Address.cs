using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Address
    {

        public Address() { }

        

        public Address( string region , string state , string city , string address1 , string address2 , string zipCode , string label)
        {
            this.Region = region;
            this.State = state;
            this.City = city;
            this.Address1 = address1;
            this.Address2 = address2;
            this.ZipCode = zipCode;
            this.Label = label;
        }

            public string Region { get; set; }
            public string State { get; set; }
            public string City { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string ZipCode { get; set; }
            public string Label { get; set; }

        

    }

}
