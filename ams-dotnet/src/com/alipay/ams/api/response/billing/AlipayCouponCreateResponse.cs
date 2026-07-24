using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCouponCreateResponse : AMSResponse
    {

        public AlipayCouponCreateResponse() { }

        

        public AlipayCouponCreateResponse( CouponCreateResult result , string couponId , string couponName , string discountType , string status , List<PromotionCode> promotionCodes)
        {
            this.Result = result;
            this.CouponId = couponId;
            this.CouponName = couponName;
            this.DiscountType = discountType;
            this.Status = status;
            this.PromotionCodes = promotionCodes;
        }

            public CouponCreateResult Result { get; set; }
            public string CouponId { get; set; }
            public string CouponName { get; set; }
            public string DiscountType { get; set; }
            public string Status { get; set; }
            public List<PromotionCode> PromotionCodes { get; set; }

        

    }

}
