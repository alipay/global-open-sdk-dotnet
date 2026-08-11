using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CouponApplicableProduct
    {

        public CouponApplicableProduct() { }

        

        public CouponApplicableProduct( bool? canDelete , string gmtModified , int? priceCount , string productId , string productName , string status)
        {
            this.CanDelete = canDelete;
            this.GmtModified = gmtModified;
            this.PriceCount = priceCount;
            this.ProductId = productId;
            this.ProductName = productName;
            this.Status = status;
        }

            public bool? CanDelete { get; set; }
            public string GmtModified { get; set; }
            public int? PriceCount { get; set; }
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public string Status { get; set; }

        

    }

}
