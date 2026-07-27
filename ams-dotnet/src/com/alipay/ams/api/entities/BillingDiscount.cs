using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingDiscount
    {

        public BillingDiscount() { }

        

        public BillingDiscount( string couponId , string promotionCodeId)
        {
            this.CouponId = couponId;
            this.PromotionCodeId = promotionCodeId;
        }

            public string CouponId { get; set; }
            public string PromotionCodeId { get; set; }

        

    }

}
