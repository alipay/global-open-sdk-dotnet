using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayPromotionCodeInquireDetailsResponse : AMSResponse
    {

        public AlipayPromotionCodeInquireDetailsResponse() { }

        

        public AlipayPromotionCodeInquireDetailsResponse( Result result , string promotionCodeId , string promotionCodeRequestId , string code , string couponId , string status , int? maxRedemptions , int? redeemedCount , string expiryTime , PromotionCodeInquireDetailsMinAmount minAmount , bool? oneTimeOnly , string customerId , Dictionary<string, string> metadata , string createTime , string updateTime)
        {
            this.Result = result;
            this.PromotionCodeId = promotionCodeId;
            this.PromotionCodeRequestId = promotionCodeRequestId;
            this.Code = code;
            this.CouponId = couponId;
            this.Status = status;
            this.MaxRedemptions = maxRedemptions;
            this.RedeemedCount = redeemedCount;
            this.ExpiryTime = expiryTime;
            this.MinAmount = minAmount;
            this.OneTimeOnly = oneTimeOnly;
            this.CustomerId = customerId;
            this.Metadata = metadata;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

            public Result Result { get; set; }
            public string PromotionCodeId { get; set; }
            public string PromotionCodeRequestId { get; set; }
            public string Code { get; set; }
            public string CouponId { get; set; }
            public string Status { get; set; }
            public int? MaxRedemptions { get; set; }
            public int? RedeemedCount { get; set; }
            public string ExpiryTime { get; set; }
            public PromotionCodeInquireDetailsMinAmount MinAmount { get; set; }
            public bool? OneTimeOnly { get; set; }
            public string CustomerId { get; set; }
            public Dictionary<string, string> Metadata { get; set; }
            public string CreateTime { get; set; }
            public string UpdateTime { get; set; }

        

    }

}
