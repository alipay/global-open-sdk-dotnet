using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxCalculatedLineItem
    {

        public TaxCalculatedLineItem() { }

        

        public TaxCalculatedLineItem( string goodsReferenceId , string unitAmount , string amount , int? quantity , string taxCode , string taxBehavior , string taxAmount , List<TaxBreakdown> taxBreakdown)
        {
            this.GoodsReferenceId = goodsReferenceId;
            this.UnitAmount = unitAmount;
            this.Amount = amount;
            this.Quantity = quantity;
            this.TaxCode = taxCode;
            this.TaxBehavior = taxBehavior;
            this.TaxAmount = taxAmount;
            this.TaxBreakdown = taxBreakdown;
        }

            public string GoodsReferenceId { get; set; }
            public string UnitAmount { get; set; }
            public string Amount { get; set; }
            public int? Quantity { get; set; }
            public string TaxCode { get; set; }
            public string TaxBehavior { get; set; }
            public string TaxAmount { get; set; }
            public List<TaxBreakdown> TaxBreakdown { get; set; }

        

    }

}
