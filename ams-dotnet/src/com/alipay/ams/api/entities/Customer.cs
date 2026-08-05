using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Customer
    {

        public Customer() { }

        

        public Customer( string customerId , string customerRequestId , string email , string firstName , string lastName , string status , string phoneNo , string countryCode , string billingEmail , string shippingFirstName , string shippingLastName , string shippingCountryCode)
        {
            this.CustomerId = customerId;
            this.CustomerRequestId = customerRequestId;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Status = status;
            this.PhoneNo = phoneNo;
            this.CountryCode = countryCode;
            this.BillingEmail = billingEmail;
            this.ShippingFirstName = shippingFirstName;
            this.ShippingLastName = shippingLastName;
            this.ShippingCountryCode = shippingCountryCode;
        }

            public string CustomerId { get; set; }
            public string CustomerRequestId { get; set; }
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Status { get; set; }
            public string PhoneNo { get; set; }
            public string CountryCode { get; set; }
            public string BillingEmail { get; set; }
            public string ShippingFirstName { get; set; }
            public string ShippingLastName { get; set; }
            public string ShippingCountryCode { get; set; }

        

    }

}
