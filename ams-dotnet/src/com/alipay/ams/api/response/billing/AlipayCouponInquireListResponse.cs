using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCouponInquireListResponse : AMSResponse
    {

        public AlipayCouponInquireListResponse() { }

        

        public AlipayCouponInquireListResponse( ResultInfo result , List<Coupon> coupons , bool? hasMore , string nextCursor , int? total , string previousCursor)
        {
            this.Result = result;
            this.Coupons = coupons;
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
            this.Total = total;
            this.PreviousCursor = previousCursor;
        }

            public ResultInfo Result { get; set; }
            public List<Coupon> Coupons { get; set; }
            public bool? HasMore { get; set; }
            public string NextCursor { get; set; }
            public int? Total { get; set; }
            public string PreviousCursor { get; set; }

        

    }

}
