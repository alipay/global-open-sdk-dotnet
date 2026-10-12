using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InvoiceCreateItem
    {

        public InvoiceCreateItem() { }

        

        public InvoiceCreateItem( Amount discountAmount , string taxBehavior , string taxCode , string description , Amount itemAmount , Amount unitAmount , string priceId , string productId , int? quantity , string itemId , string supplyStart , string supplyEnd)
        {
            this.DiscountAmount = discountAmount;
            this.TaxBehavior = taxBehavior;
            this.TaxCode = taxCode;
            this.Description = description;
            this.ItemAmount = itemAmount;
            this.UnitAmount = unitAmount;
            this.PriceId = priceId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.ItemId = itemId;
            this.SupplyStart = supplyStart;
            this.SupplyEnd = supplyEnd;
        }

            public Amount DiscountAmount { get; set; }
            public string TaxBehavior { get; set; }
            public string TaxCode { get; set; }
            public string Description { get; set; }
            public Amount ItemAmount { get; set; }
            public Amount UnitAmount { get; set; }
            public string PriceId { get; set; }
            public string ProductId { get; set; }
            public int? Quantity { get; set; }
            public string ItemId { get; set; }
            public string SupplyStart { get; set; }
            public string SupplyEnd { get; set; }

        

    }

}
