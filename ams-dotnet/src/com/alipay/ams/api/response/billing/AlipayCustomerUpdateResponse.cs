using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCustomerUpdateResponse : AMSResponse
    {

        public AlipayCustomerUpdateResponse() { }

        

        public AlipayCustomerUpdateResponse( Result result , string customerId , string status)
        {
            this.Result = result;
            this.CustomerId = customerId;
            this.Status = status;
        }

            public Result Result { get; set; }
            public string CustomerId { get; set; }
            public string Status { get; set; }

        

    }

}
