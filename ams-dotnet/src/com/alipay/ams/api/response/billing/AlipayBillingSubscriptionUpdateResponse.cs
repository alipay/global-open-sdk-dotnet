using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayBillingSubscriptionUpdateResponse : AMSResponse
    {

        public AlipayBillingSubscriptionUpdateResponse() { }

        

        public AlipayBillingSubscriptionUpdateResponse( ResultInfo result , string subscriptionId , string status , string billingCycleAnchor , BillingSubscriptionUpdatePauseCollection pauseCollection , BillingSubscriptionUpdateTrialSettings trialSettings , List<SubscriptionItem> subscriptionItems , string prorationInvoiceId , string creditNoteId , bool? cancelAtPeriodEnd , string canceledAt , string prorationDate)
        {
            this.Result = result;
            this.SubscriptionId = subscriptionId;
            this.Status = status;
            this.BillingCycleAnchor = billingCycleAnchor;
            this.PauseCollection = pauseCollection;
            this.TrialSettings = trialSettings;
            this.SubscriptionItems = subscriptionItems;
            this.ProrationInvoiceId = prorationInvoiceId;
            this.CreditNoteId = creditNoteId;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.CanceledAt = canceledAt;
            this.ProrationDate = prorationDate;
        }

            public ResultInfo Result { get; set; }
            public string SubscriptionId { get; set; }
            public string Status { get; set; }
            public string BillingCycleAnchor { get; set; }
            public BillingSubscriptionUpdatePauseCollection PauseCollection { get; set; }
            public BillingSubscriptionUpdateTrialSettings TrialSettings { get; set; }
            public List<SubscriptionItem> SubscriptionItems { get; set; }
            public string ProrationInvoiceId { get; set; }
            public string CreditNoteId { get; set; }
            public bool? CancelAtPeriodEnd { get; set; }
            public string CanceledAt { get; set; }
            public string ProrationDate { get; set; }

        

    }

}
