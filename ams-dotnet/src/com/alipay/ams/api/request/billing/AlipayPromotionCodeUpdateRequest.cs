using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayPromotionCodeUpdateRequest : AMSRequest<AlipayPromotionCodeUpdateResponse>
    {

        public AlipayPromotionCodeUpdateRequest() { }

        

        public AlipayPromotionCodeUpdateRequest( string promotionCodeId , string status , int? maxRedemptions , string expiryTime , Dictionary<string, string> metadata)
        {
            this.PromotionCodeId = promotionCodeId;
            this.Status = status;
            this.MaxRedemptions = maxRedemptions;
            this.ExpiryTime = expiryTime;
            this.Metadata = metadata;
        }

            public string PromotionCodeId { get; set; }
            public string Status { get; set; }
            public int? MaxRedemptions { get; set; }
            public string ExpiryTime { get; set; }
            public Dictionary<string, string> Metadata { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/promotionCode/update"; } 


    }

}
