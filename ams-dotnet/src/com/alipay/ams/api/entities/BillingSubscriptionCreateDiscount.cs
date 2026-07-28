using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionCreateDiscount
    {

        public BillingSubscriptionCreateDiscount() { }

        

        public BillingSubscriptionCreateDiscount( string couponId , string promotionCodeId)
        {
            this.CouponId = couponId;
            this.PromotionCodeId = promotionCodeId;
        }

            public string CouponId { get; set; }
            public string PromotionCodeId { get; set; }

        

    }

}
