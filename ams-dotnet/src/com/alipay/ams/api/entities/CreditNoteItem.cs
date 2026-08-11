using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CreditNoteItem
    {

        public CreditNoteItem() { }

        

        public CreditNoteItem( string creditNoteItemId , string type , string invoiceItemId , string description , int? quantity , Amount unitAmount , Amount itemAmount)
        {
            this.CreditNoteItemId = creditNoteItemId;
            this.Type = type;
            this.InvoiceItemId = invoiceItemId;
            this.Description = description;
            this.Quantity = quantity;
            this.UnitAmount = unitAmount;
            this.ItemAmount = itemAmount;
        }

            public string CreditNoteItemId { get; set; }
            public string Type { get; set; }
            public string InvoiceItemId { get; set; }
            public string Description { get; set; }
            public int? Quantity { get; set; }
            public Amount UnitAmount { get; set; }
            public Amount ItemAmount { get; set; }

        

    }

}
