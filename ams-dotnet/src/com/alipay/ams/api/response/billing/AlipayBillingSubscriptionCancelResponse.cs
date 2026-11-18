using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayBillingSubscriptionCancelResponse : AMSResponse
    {

        public AlipayBillingSubscriptionCancelResponse() { }

        

        public AlipayBillingSubscriptionCancelResponse( ResultInfo result , string subscriptionId , string status , string canceledAt , bool? cancelAtPeriodEnd , string creditNoteId , long? creditNoteAmount , string creditNoteCurrency)
        {
            this.Result = result;
            this.SubscriptionId = subscriptionId;
            this.Status = status;
            this.CanceledAt = canceledAt;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.CreditNoteId = creditNoteId;
            this.CreditNoteAmount = creditNoteAmount;
            this.CreditNoteCurrency = creditNoteCurrency;
        }

            public ResultInfo Result { get; set; }
            public string SubscriptionId { get; set; }
            public string Status { get; set; }
            public string CanceledAt { get; set; }
            public bool? CancelAtPeriodEnd { get; set; }
            public string CreditNoteId { get; set; }
            public long? CreditNoteAmount { get; set; }
            public string CreditNoteCurrency { get; set; }

        

    }

}
