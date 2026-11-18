using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionDiscountInfo
    {

        public BillingSubscriptionDiscountInfo() { }

        

        public BillingSubscriptionDiscountInfo( string discountId , string couponId , string type , string percentOff , Amount amountOff , string duration , int? times , string status)
        {
            this.DiscountId = discountId;
            this.CouponId = couponId;
            this.Type = type;
            this.PercentOff = percentOff;
            this.AmountOff = amountOff;
            this.Duration = duration;
            this.Times = times;
            this.Status = status;
        }

            public string DiscountId { get; set; }
            public string CouponId { get; set; }
            public string Type { get; set; }
            public string PercentOff { get; set; }
            public Amount AmountOff { get; set; }
            public string Duration { get; set; }
            public int? Times { get; set; }
            public string Status { get; set; }

        

    }

}
