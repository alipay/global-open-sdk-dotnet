using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxCalculatedLineItem
    {

        public TaxCalculatedLineItem() { }

        

        public TaxCalculatedLineItem( string goodsReferenceId , Amount amount , int? quantity , string taxCode , string taxBehavior , Amount taxAmount , List<TaxBreakdown> taxBreakdown)
        {
            this.GoodsReferenceId = goodsReferenceId;
            this.Amount = amount;
            this.Quantity = quantity;
            this.TaxCode = taxCode;
            this.TaxBehavior = taxBehavior;
            this.TaxAmount = taxAmount;
            this.TaxBreakdown = taxBreakdown;
        }

            public string GoodsReferenceId { get; set; }
            public Amount Amount { get; set; }
            public int? Quantity { get; set; }
            public string TaxCode { get; set; }
            public string TaxBehavior { get; set; }
            public Amount TaxAmount { get; set; }
            public List<TaxBreakdown> TaxBreakdown { get; set; }

        

    }

}
