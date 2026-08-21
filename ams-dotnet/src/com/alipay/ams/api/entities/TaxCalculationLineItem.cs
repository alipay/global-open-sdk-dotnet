using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxCalculationLineItem
    {

        public TaxCalculationLineItem() { }

        

        public TaxCalculationLineItem( string goodsReferenceId , string amount , int? quantity , string taxCode , string productId , string taxBehavior)
        {
            this.GoodsReferenceId = goodsReferenceId;
            this.Amount = amount;
            this.Quantity = quantity;
            this.TaxCode = taxCode;
            this.ProductId = productId;
            this.TaxBehavior = taxBehavior;
        }

            public string GoodsReferenceId { get; set; }
            public string Amount { get; set; }
            public int? Quantity { get; set; }
            public string TaxCode { get; set; }
            public string ProductId { get; set; }
            public string TaxBehavior { get; set; }

        

    }

}
