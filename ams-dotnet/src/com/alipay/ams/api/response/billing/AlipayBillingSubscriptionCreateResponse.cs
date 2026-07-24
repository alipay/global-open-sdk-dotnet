using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayBillingSubscriptionCreateResponse : AMSResponse
    {

        public AlipayBillingSubscriptionCreateResponse() { }

        

        public AlipayBillingSubscriptionCreateResponse( ResultInfo result , string subscriptionRequestId , string subscriptionId , string customerId , string invoiceId , string status , string currentPeriodStart , string currentPeriodEnd , string billingCycleAnchor , string trialStart , string trialEnd , string cancelAt , bool? cancelAtPeriodEnd , string description , string collectionMethod , int? daysUntilDue , List<SubscriptionItem> subscriptionItems , List<Discount> discounts , string subscriptionNotifyUrl)
        {
            this.Result = result;
            this.SubscriptionRequestId = subscriptionRequestId;
            this.SubscriptionId = subscriptionId;
            this.CustomerId = customerId;
            this.InvoiceId = invoiceId;
            this.Status = status;
            this.CurrentPeriodStart = currentPeriodStart;
            this.CurrentPeriodEnd = currentPeriodEnd;
            this.BillingCycleAnchor = billingCycleAnchor;
            this.TrialStart = trialStart;
            this.TrialEnd = trialEnd;
            this.CancelAt = cancelAt;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.Description = description;
            this.CollectionMethod = collectionMethod;
            this.DaysUntilDue = daysUntilDue;
            this.SubscriptionItems = subscriptionItems;
            this.Discounts = discounts;
            this.SubscriptionNotifyUrl = subscriptionNotifyUrl;
        }

            public ResultInfo Result { get; set; }
            public string SubscriptionRequestId { get; set; }
            public string SubscriptionId { get; set; }
            public string CustomerId { get; set; }
            public string InvoiceId { get; set; }
            public string Status { get; set; }
            public string CurrentPeriodStart { get; set; }
            public string CurrentPeriodEnd { get; set; }
            public string BillingCycleAnchor { get; set; }
            public string TrialStart { get; set; }
            public string TrialEnd { get; set; }
            public string CancelAt { get; set; }
            public bool? CancelAtPeriodEnd { get; set; }
            public string Description { get; set; }
            public string CollectionMethod { get; set; }
            public int? DaysUntilDue { get; set; }
            public List<SubscriptionItem> SubscriptionItems { get; set; }
            public List<Discount> Discounts { get; set; }
            public string SubscriptionNotifyUrl { get; set; }

        

    }

}
