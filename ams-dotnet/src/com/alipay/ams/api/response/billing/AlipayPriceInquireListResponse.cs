using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayPriceInquireListResponse : AMSResponse
    {

        public AlipayPriceInquireListResponse() { }

        

        public AlipayPriceInquireListResponse( Result result , List<Price> prices , bool? hasMore , int? total)
        {
            this.Result = result;
            this.Prices = prices;
            this.HasMore = hasMore;
            this.Total = total;
        }

            public Result Result { get; set; }
            public List<Price> Prices { get; set; }
            public bool? HasMore { get; set; }
            public int? Total { get; set; }

        

    }

}
