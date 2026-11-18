using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InvoiceItem
    {

        public InvoiceItem() { }

        

        public InvoiceItem( string itemId , string priceId , string description , string quantity , Amount unitAmount , Amount amount , Amount usageAmount , string usageQuantity , string periodStart , string periodEnd , bool? proration , Amount discountAmount , Amount taxAmount , string gmtCreate , string gmtUpdate)
        {
            this.ItemId = itemId;
            this.PriceId = priceId;
            this.Description = description;
            this.Quantity = quantity;
            this.UnitAmount = unitAmount;
            this.Amount = amount;
            this.UsageAmount = usageAmount;
            this.UsageQuantity = usageQuantity;
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            this.Proration = proration;
            this.DiscountAmount = discountAmount;
            this.TaxAmount = taxAmount;
            this.GmtCreate = gmtCreate;
            this.GmtUpdate = gmtUpdate;
        }

            public string ItemId { get; set; }
            public string PriceId { get; set; }
            public string Description { get; set; }
            public string Quantity { get; set; }
            public Amount UnitAmount { get; set; }
            public Amount Amount { get; set; }
            public Amount UsageAmount { get; set; }
            public string UsageQuantity { get; set; }
            public string PeriodStart { get; set; }
            public string PeriodEnd { get; set; }
            public bool? Proration { get; set; }
            public Amount DiscountAmount { get; set; }
            public Amount TaxAmount { get; set; }
            public string GmtCreate { get; set; }
            public string GmtUpdate { get; set; }

        

    }

}
