using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CouponCreateAppliesTo
    {

        public CouponCreateAppliesTo() { }

        

        public CouponCreateAppliesTo( List<string> productIds)
        {
            this.ProductIds = productIds;
        }

            public List<string> ProductIds { get; set; }

        

    }

}
