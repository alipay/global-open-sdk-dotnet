using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CouponPaymentMethodDetail
    {

        public CouponPaymentMethodDetail() { }

        

        public CouponPaymentMethodDetail( string couponId , Amount availableAmount , string couponName , string couponDescription , string couponExpireTime , string paymentMethodDetailMetadata)
        {
            this.CouponId = couponId;
            this.AvailableAmount = availableAmount;
            this.CouponName = couponName;
            this.CouponDescription = couponDescription;
            this.CouponExpireTime = couponExpireTime;
            this.PaymentMethodDetailMetadata = paymentMethodDetailMetadata;
        }

            public string CouponId { get; set; }
            public Amount AvailableAmount { get; set; }
            public string CouponName { get; set; }
            public string CouponDescription { get; set; }
            public string CouponExpireTime { get; set; }
            public string PaymentMethodDetailMetadata { get; set; }

        

    }

}
