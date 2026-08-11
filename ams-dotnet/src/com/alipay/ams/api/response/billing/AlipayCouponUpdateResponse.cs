using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCouponUpdateResponse : AMSResponse
    {

        public AlipayCouponUpdateResponse() { }

        

        public AlipayCouponUpdateResponse( ResultInfo result , string couponId , string status)
        {
            this.Result = result;
            this.CouponId = couponId;
            this.Status = status;
        }

            public ResultInfo Result { get; set; }
            public string CouponId { get; set; }
            public string Status { get; set; }

        

    }

}
