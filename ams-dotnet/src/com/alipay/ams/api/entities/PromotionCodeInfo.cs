using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PromotionCodeInfo
    {

        public PromotionCodeInfo() { }

        

        public PromotionCodeInfo( string promotionCodeId , string code , string status , int? maxRedemptions , int? redeemedCount , string expiryTime , string createTime)
        {
            this.PromotionCodeId = promotionCodeId;
            this.Code = code;
            this.Status = status;
            this.MaxRedemptions = maxRedemptions;
            this.RedeemedCount = redeemedCount;
            this.ExpiryTime = expiryTime;
            this.CreateTime = createTime;
        }

            public string PromotionCodeId { get; set; }
            public string Code { get; set; }
            public string Status { get; set; }
            public int? MaxRedemptions { get; set; }
            public int? RedeemedCount { get; set; }
            public string ExpiryTime { get; set; }
            public string CreateTime { get; set; }

        

    }

}
