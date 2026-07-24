using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayBillingSubscriptionCancelResponse : AMSResponse
    {

        public AlipayBillingSubscriptionCancelResponse() { }

        

        public AlipayBillingSubscriptionCancelResponse( ResultInfo result , string subscriptionId , string status , string cancellationReason , BillingSubscriptionCancelCancellationDetails cancellationDetails , string canceledAt , bool? cancelAtPeriodEnd , string creditNoteId)
        {
            this.Result = result;
            this.SubscriptionId = subscriptionId;
            this.Status = status;
            this.CancellationReason = cancellationReason;
            this.CancellationDetails = cancellationDetails;
            this.CanceledAt = canceledAt;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.CreditNoteId = creditNoteId;
        }

            public ResultInfo Result { get; set; }
            public string SubscriptionId { get; set; }
            public string Status { get; set; }
            public string CancellationReason { get; set; }
            public BillingSubscriptionCancelCancellationDetails CancellationDetails { get; set; }
            public string CanceledAt { get; set; }
            public bool? CancelAtPeriodEnd { get; set; }
            public string CreditNoteId { get; set; }

        

    }

}
