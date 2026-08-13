using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CouponPromotionCode
    {

        public CouponPromotionCode() { }

        

        public CouponPromotionCode( string promotionCodeId , string code , string status)
        {
            this.PromotionCodeId = promotionCodeId;
            this.Code = code;
            this.Status = status;
        }

            public string PromotionCodeId { get; set; }
            public string Code { get; set; }
            public string Status { get; set; }

        

    }

}
