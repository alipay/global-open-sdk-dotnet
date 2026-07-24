using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCustomerInquireListResponse : AMSResponse
    {

        public AlipayCustomerInquireListResponse() { }

        

        public AlipayCustomerInquireListResponse( Result result , List<Customer> customers , int? total , bool? hasMore , string nextCursor)
        {
            this.Result = result;
            this.Customers = customers;
            this.Total = total;
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

            public Result Result { get; set; }
            public List<Customer> Customers { get; set; }
            public int? Total { get; set; }
            public bool? HasMore { get; set; }
            public string NextCursor { get; set; }

        

    }

}
