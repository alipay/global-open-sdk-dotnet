using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionDiscount
    {

        public BillingSubscriptionDiscount() { }

        

        public BillingSubscriptionDiscount( string couponId , string promotionCodeId)
        {
            this.CouponId = couponId;
            this.PromotionCodeId = promotionCodeId;
        }

            public string CouponId { get; set; }
            public string PromotionCodeId { get; set; }

        

    }

}
