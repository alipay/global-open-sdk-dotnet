using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class LineItem
    {

        public LineItem() { }

        

        public LineItem( string creditNoteItemId , string type , string invoiceItemId , string description , string quantity , Amount unitAmount , Amount itemAmount , Dictionary<string, string> metadata)
        {
            this.CreditNoteItemId = creditNoteItemId;
            this.Type = type;
            this.InvoiceItemId = invoiceItemId;
            this.Description = description;
            this.Quantity = quantity;
            this.UnitAmount = unitAmount;
            this.ItemAmount = itemAmount;
            this.Metadata = metadata;
        }

            public string CreditNoteItemId { get; set; }
            public string Type { get; set; }
            public string InvoiceItemId { get; set; }
            public string Description { get; set; }
            public string Quantity { get; set; }
            public Amount UnitAmount { get; set; }
            public Amount ItemAmount { get; set; }
            public Dictionary<string, string> Metadata { get; set; }

        

    }

}
