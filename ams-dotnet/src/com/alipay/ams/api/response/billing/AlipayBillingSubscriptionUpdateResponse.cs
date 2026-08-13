using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayBillingSubscriptionUpdateResponse : AMSResponse
    {

        public AlipayBillingSubscriptionUpdateResponse() { }

        

        public AlipayBillingSubscriptionUpdateResponse( ResultInfo result , string subscriptionId , string status , List<SubscriptionItem> subscriptionItems , string prorationInvoiceId , long? prorationInvoiceAmount , string prorationInvoiceCurrency , string creditNoteId , long? creditNoteAmount , string creditNoteCurrency , bool? pendingUpdate)
        {
            this.Result = result;
            this.SubscriptionId = subscriptionId;
            this.Status = status;
            this.SubscriptionItems = subscriptionItems;
            this.ProrationInvoiceId = prorationInvoiceId;
            this.ProrationInvoiceAmount = prorationInvoiceAmount;
            this.ProrationInvoiceCurrency = prorationInvoiceCurrency;
            this.CreditNoteId = creditNoteId;
            this.CreditNoteAmount = creditNoteAmount;
            this.CreditNoteCurrency = creditNoteCurrency;
            this.PendingUpdate = pendingUpdate;
        }

            public ResultInfo Result { get; set; }
            public string SubscriptionId { get; set; }
            public string Status { get; set; }
            public List<SubscriptionItem> SubscriptionItems { get; set; }
            public string ProrationInvoiceId { get; set; }
            public long? ProrationInvoiceAmount { get; set; }
            public string ProrationInvoiceCurrency { get; set; }
            public string CreditNoteId { get; set; }
            public long? CreditNoteAmount { get; set; }
            public string CreditNoteCurrency { get; set; }
            public bool? PendingUpdate { get; set; }

        

    }

}
