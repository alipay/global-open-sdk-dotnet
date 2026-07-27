using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PromotionCode
    {

        public PromotionCode() { }

        

        public PromotionCode( string promotionCodeRequestId , string code , int? maxRedemptions , string expiryTime , Amount minAmount , bool? oneTimeOnly , string customerId , Dictionary<string, string> metadata)
        {
            this.PromotionCodeRequestId = promotionCodeRequestId;
            this.Code = code;
            this.MaxRedemptions = maxRedemptions;
            this.ExpiryTime = expiryTime;
            this.MinAmount = minAmount;
            this.OneTimeOnly = oneTimeOnly;
            this.CustomerId = customerId;
            this.Metadata = metadata;
        }

            public string PromotionCodeRequestId { get; set; }
            public string Code { get; set; }
            public int? MaxRedemptions { get; set; }
            public string ExpiryTime { get; set; }
            public Amount MinAmount { get; set; }
            public bool? OneTimeOnly { get; set; }
            public string CustomerId { get; set; }
            public Dictionary<string, string> Metadata { get; set; }

        

    }

}
