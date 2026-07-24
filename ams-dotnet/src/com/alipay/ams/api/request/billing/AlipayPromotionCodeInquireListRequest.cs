using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayPromotionCodeInquireListRequest : AMSRequest<AlipayPromotionCodeInquireListResponse>
    {

        public AlipayPromotionCodeInquireListRequest() { }

        

        public AlipayPromotionCodeInquireListRequest( string couponId , string status , string startingAfter , string endingBefore , int? limit , bool? includeTotal)
        {
            this.CouponId = couponId;
            this.Status = status;
            this.StartingAfter = startingAfter;
            this.EndingBefore = endingBefore;
            this.Limit = limit;
            this.IncludeTotal = includeTotal;
        }

            public string CouponId { get; set; }
            public string Status { get; set; }
            public string StartingAfter { get; set; }
            public string EndingBefore { get; set; }
            public int? Limit { get; set; }
            public bool? IncludeTotal { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/promotionCode/inquireList"; } 


    }

}
