using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCouponInquireDetailsResponse : AMSResponse
    {

        public AlipayCouponInquireDetailsResponse() { }

        

        public AlipayCouponInquireDetailsResponse( ResultInfo result , string couponId , string couponRequestId , string couponName , string discountType , string percentOff , Amount amountOff , string durationType , int? durationValue , string durationUnit , string redeemBy , CouponInquireDetailsAppliesTo appliesTo , string status , string metadata , string gmtCreate , int? maxRedemptions , int? redeemedCount)
        {
            this.Result = result;
            this.CouponId = couponId;
            this.CouponRequestId = couponRequestId;
            this.CouponName = couponName;
            this.DiscountType = discountType;
            this.PercentOff = percentOff;
            this.AmountOff = amountOff;
            this.DurationType = durationType;
            this.DurationValue = durationValue;
            this.DurationUnit = durationUnit;
            this.RedeemBy = redeemBy;
            this.AppliesTo = appliesTo;
            this.Status = status;
            this.Metadata = metadata;
            this.GmtCreate = gmtCreate;
            this.MaxRedemptions = maxRedemptions;
            this.RedeemedCount = redeemedCount;
        }

            public ResultInfo Result { get; set; }
            public string CouponId { get; set; }
            public string CouponRequestId { get; set; }
            public string CouponName { get; set; }
            public string DiscountType { get; set; }
            public string PercentOff { get; set; }
            public Amount AmountOff { get; set; }
            public string DurationType { get; set; }
            public int? DurationValue { get; set; }
            public string DurationUnit { get; set; }
            public string RedeemBy { get; set; }
            public CouponInquireDetailsAppliesTo AppliesTo { get; set; }
            public string Status { get; set; }
            public string Metadata { get; set; }
            public string GmtCreate { get; set; }
            public int? MaxRedemptions { get; set; }
            public int? RedeemedCount { get; set; }

        

    }

}
