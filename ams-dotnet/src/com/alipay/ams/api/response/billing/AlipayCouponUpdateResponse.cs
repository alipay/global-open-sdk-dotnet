using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCouponUpdateResponse : AMSResponse
    {

        public AlipayCouponUpdateResponse() { }

        

        public AlipayCouponUpdateResponse( CouponUpdateResult result , string couponId , string couponName , string status , int? maxRedemptions , int? redeemedCount , string redeemBy , Dictionary<string, string> metadata , string updateTime)
        {
            this.Result = result;
            this.CouponId = couponId;
            this.CouponName = couponName;
            this.Status = status;
            this.MaxRedemptions = maxRedemptions;
            this.RedeemedCount = redeemedCount;
            this.RedeemBy = redeemBy;
            this.Metadata = metadata;
            this.UpdateTime = updateTime;
        }

            public CouponUpdateResult Result { get; set; }
            public string CouponId { get; set; }
            public string CouponName { get; set; }
            public string Status { get; set; }
            public int? MaxRedemptions { get; set; }
            public int? RedeemedCount { get; set; }
            public string RedeemBy { get; set; }
            public Dictionary<string, string> Metadata { get; set; }
            public string UpdateTime { get; set; }

        

    }

}
