using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCustomerCreateResponse : AMSResponse
    {

        public AlipayCustomerCreateResponse() { }

        

        public AlipayCustomerCreateResponse( Result result , string customerId , string customerRequestId , string email , string status)
        {
            this.Result = result;
            this.CustomerId = customerId;
            this.CustomerRequestId = customerRequestId;
            this.Email = email;
            this.Status = status;
        }

            public Result Result { get; set; }
            public string CustomerId { get; set; }
            public string CustomerRequestId { get; set; }
            public string Email { get; set; }
            public string Status { get; set; }

        

    }

}
