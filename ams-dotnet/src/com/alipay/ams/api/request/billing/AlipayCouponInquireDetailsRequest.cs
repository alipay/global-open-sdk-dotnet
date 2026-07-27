using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCouponInquireDetailsRequest : AMSRequest<AlipayCouponInquireDetailsResponse>
    {

        public AlipayCouponInquireDetailsRequest() { }

        

        public AlipayCouponInquireDetailsRequest( string couponId)
        {
            this.CouponId = couponId;
        }

            public string CouponId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/coupon/inquireDetails"; } 


    }

}
