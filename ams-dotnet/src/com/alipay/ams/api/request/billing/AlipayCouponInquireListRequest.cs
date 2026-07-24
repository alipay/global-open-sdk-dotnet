using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCouponInquireListRequest : AMSRequest<AlipayCouponInquireListResponse>
    {

        public AlipayCouponInquireListRequest() { }

        

        public AlipayCouponInquireListRequest( string status , string discountType , string startingAfter , string endingBefore , int? limit , bool? includeTotal)
        {
            this.Status = status;
            this.DiscountType = discountType;
            this.StartingAfter = startingAfter;
            this.EndingBefore = endingBefore;
            this.Limit = limit;
            this.IncludeTotal = includeTotal;
        }

            public string Status { get; set; }
            public string DiscountType { get; set; }
            public string StartingAfter { get; set; }
            public string EndingBefore { get; set; }
            public int? Limit { get; set; }
            public bool? IncludeTotal { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/coupon/inquireList"; } 


    }

}
