using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayPromotionCodeCreateRequest : AMSRequest<AlipayPromotionCodeCreateResponse>
    {

        public AlipayPromotionCodeCreateRequest() { }

        

        public AlipayPromotionCodeCreateRequest( string promotionCodeRequestId , string couponId , string code , int? maxRedeemSize , string expiryTime , PromotionCodeCreateMinAmount minAmount , bool? oneTimeOnly , string customerId , Dictionary<string, string> metadata)
        {
            this.PromotionCodeRequestId = promotionCodeRequestId;
            this.CouponId = couponId;
            this.Code = code;
            this.MaxRedeemSize = maxRedeemSize;
            this.ExpiryTime = expiryTime;
            this.MinAmount = minAmount;
            this.OneTimeOnly = oneTimeOnly;
            this.CustomerId = customerId;
            this.Metadata = metadata;
        }

            public string PromotionCodeRequestId { get; set; }
            public string CouponId { get; set; }
            public string Code { get; set; }
            public int? MaxRedeemSize { get; set; }
            public string ExpiryTime { get; set; }
            public PromotionCodeCreateMinAmount MinAmount { get; set; }
            public bool? OneTimeOnly { get; set; }
            public string CustomerId { get; set; }
            public Dictionary<string, string> Metadata { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/promotionCode/create"; } 


    }

}
