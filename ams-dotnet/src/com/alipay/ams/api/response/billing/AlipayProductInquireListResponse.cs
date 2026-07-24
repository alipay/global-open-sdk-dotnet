using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayProductInquireListResponse : AMSResponse
    {

        public AlipayProductInquireListResponse() { }

        

        public AlipayProductInquireListResponse( Result result , List<Product> products , bool? hasMore , int? totalCount)
        {
            this.Result = result;
            this.Products = products;
            this.HasMore = hasMore;
            this.TotalCount = totalCount;
        }

            public Result Result { get; set; }
            public List<Product> Products { get; set; }
            public bool? HasMore { get; set; }
            public int? TotalCount { get; set; }

        

    }

}
