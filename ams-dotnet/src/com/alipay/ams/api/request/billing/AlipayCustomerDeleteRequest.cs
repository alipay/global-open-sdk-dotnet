using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCustomerDeleteRequest : AMSRequest<AlipayCustomerDeleteResponse>
    {

        public AlipayCustomerDeleteRequest() { }

        

        public AlipayCustomerDeleteRequest( string customerId)
        {
            this.CustomerId = customerId;
        }

            public string CustomerId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/customer/delete"; } 


    }

}
