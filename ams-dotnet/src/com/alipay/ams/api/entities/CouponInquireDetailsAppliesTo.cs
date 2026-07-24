using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CouponInquireDetailsAppliesTo
    {

        public CouponInquireDetailsAppliesTo() { }

        

        public CouponInquireDetailsAppliesTo( List<string> productIds)
        {
            this.ProductIds = productIds;
        }

            public List<string> ProductIds { get; set; }

        

    }

}
