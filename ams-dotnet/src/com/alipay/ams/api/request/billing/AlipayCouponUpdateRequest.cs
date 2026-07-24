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

        

        public AlipayCouponUpdateRequest( string couponId , string couponName , string status , int? maxRedemptions , string redeemBy , Dictionary<string, string> metadata)
        {
            this.CouponId = couponId;
            this.CouponName = couponName;
            this.Status = status;
            this.MaxRedemptions = maxRedemptions;
            this.RedeemBy = redeemBy;
            this.Metadata = metadata;
        }

            public string CouponId { get; set; }
            public string CouponName { get; set; }
            public string Status { get; set; }
            public int? MaxRedemptions { get; set; }
            public string RedeemBy { get; set; }
            public Dictionary<string, string> Metadata { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/coupon/update"; } 


    }

}
