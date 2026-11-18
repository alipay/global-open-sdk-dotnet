using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CouponInquireDetailsAppliesTo
    {

        public CouponInquireDetailsAppliesTo() { }

        

        public CouponInquireDetailsAppliesTo( List<CouponApplicableProduct> products)
        {
            this.Products = products;
        }

            public List<CouponApplicableProduct> Products { get; set; }

        

    }

}
