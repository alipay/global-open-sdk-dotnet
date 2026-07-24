using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Customer
    {

        public Customer() { }

        

        public Customer( string customerId , string customerRequestId , string email , string firstName , string lastName , string status)
        {
            this.CustomerId = customerId;
            this.CustomerRequestId = customerRequestId;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Status = status;
        }

            public string CustomerId { get; set; }
            public string CustomerRequestId { get; set; }
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Status { get; set; }

        

    }

}
