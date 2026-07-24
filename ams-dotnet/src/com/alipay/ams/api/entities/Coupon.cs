using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Coupon
    {

        public Coupon() { }

        

        public Coupon( string couponId , string couponName , string discountType , string percentOff , Amount amountOff , string redeemBy , string status , string createTime)
        {
            this.CouponId = couponId;
            this.CouponName = couponName;
            this.DiscountType = discountType;
            this.PercentOff = percentOff;
            this.AmountOff = amountOff;
            this.RedeemBy = redeemBy;
            this.Status = status;
            this.CreateTime = createTime;
        }

            public string CouponId { get; set; }
            public string CouponName { get; set; }
            public string DiscountType { get; set; }
            public string PercentOff { get; set; }
            public Amount AmountOff { get; set; }
            public string RedeemBy { get; set; }
            public string Status { get; set; }
            public string CreateTime { get; set; }

        

    }

}
