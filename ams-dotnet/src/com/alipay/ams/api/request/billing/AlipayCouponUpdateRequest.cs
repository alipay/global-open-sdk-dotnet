using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCouponUpdateRequest : AMSRequest<AlipayCouponUpdateResponse>
    {

        public AlipayCouponUpdateRequest() { }

        

        public AlipayCouponUpdateRequest( string couponId , string couponName , string status , string redeemBy , string metadata , int? maxRedemptions)
        {
            this.CouponId = couponId;
            this.CouponName = couponName;
            this.Status = status;
            this.RedeemBy = redeemBy;
            this.Metadata = metadata;
            this.MaxRedemptions = maxRedemptions;
        }

            public string CouponId { get; set; }
            public string CouponName { get; set; }
            public string Status { get; set; }
            public string RedeemBy { get; set; }
            public string Metadata { get; set; }
            public int? MaxRedemptions { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/coupon/update"; } 


    }

}
