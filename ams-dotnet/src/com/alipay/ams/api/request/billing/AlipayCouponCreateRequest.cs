using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCouponCreateRequest : AMSRequest<AlipayCouponCreateResponse>
    {

        public AlipayCouponCreateRequest() { }

        

        public AlipayCouponCreateRequest( string couponRequestId , string couponName , string discountType , string percentOff , Amount amountOff , string durationType , int? durationValue , string durationUnit , int? maxRedemptions , string redeemBy , CouponCreateAppliesTo appliesTo , Dictionary<string, string> metadata , List<PromotionCode> promotionCodes)
        {
            this.CouponRequestId = couponRequestId;
            this.CouponName = couponName;
            this.DiscountType = discountType;
            this.PercentOff = percentOff;
            this.AmountOff = amountOff;
            this.DurationType = durationType;
            this.DurationValue = durationValue;
            this.DurationUnit = durationUnit;
            this.MaxRedemptions = maxRedemptions;
            this.RedeemBy = redeemBy;
            this.AppliesTo = appliesTo;
            this.Metadata = metadata;
            this.PromotionCodes = promotionCodes;
        }

            public string CouponRequestId { get; set; }
            public string CouponName { get; set; }
            public string DiscountType { get; set; }
            public string PercentOff { get; set; }
            public Amount AmountOff { get; set; }
            public string DurationType { get; set; }
            public int? DurationValue { get; set; }
            public string DurationUnit { get; set; }
            public int? MaxRedemptions { get; set; }
            public string RedeemBy { get; set; }
            public CouponCreateAppliesTo AppliesTo { get; set; }
            public Dictionary<string, string> Metadata { get; set; }
            public List<PromotionCode> PromotionCodes { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/coupon/create"; } 


    }

}
