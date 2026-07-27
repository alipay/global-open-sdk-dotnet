using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayPromotionCodeInquireDetailsRequest : AMSRequest<AlipayPromotionCodeInquireDetailsResponse>
    {

        public AlipayPromotionCodeInquireDetailsRequest() { }

        

        public AlipayPromotionCodeInquireDetailsRequest( string promotionCodeId)
        {
            this.PromotionCodeId = promotionCodeId;
        }

            public string PromotionCodeId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/promotionCode/inquireDetails"; } 


    }

}
