using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayBillingSubscriptionInquireDetailsResponse : AMSResponse
    {

        public AlipayBillingSubscriptionInquireDetailsResponse() { }

        

        public AlipayBillingSubscriptionInquireDetailsResponse( ResultInfo result , string subscriptionId , string subscriptionRequestId , string createdAt , string status , string currentPeriodStart , string currentPeriodEnd , string billingCycleAnchor , bool? cancelAtPeriodEnd , string canceledAt , string trialStart , string trialEnd , BillingSubscriptionInquireDetailsTrialSettings trialSettings , BillingSubscriptionInquireDetailsPauseCollection pauseCollection , string cancelAt , string collectionMethod , int? daysUntilDue , BillingSubscriptionInquireDetailsCancellationDetails cancellationDetails , string terminationReason , string description , string defaultPaymentMethod , List<SubscriptionItem> subscriptionItems , List<Discount> discounts , Dictionary<string, string> metadata)
        {
            this.Result = result;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionRequestId = subscriptionRequestId;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.CurrentPeriodStart = currentPeriodStart;
            this.CurrentPeriodEnd = currentPeriodEnd;
            this.BillingCycleAnchor = billingCycleAnchor;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.CanceledAt = canceledAt;
            this.TrialStart = trialStart;
            this.TrialEnd = trialEnd;
            this.TrialSettings = trialSettings;
            this.PauseCollection = pauseCollection;
            this.CancelAt = cancelAt;
            this.CollectionMethod = collectionMethod;
            this.DaysUntilDue = daysUntilDue;
            this.CancellationDetails = cancellationDetails;
            this.TerminationReason = terminationReason;
            this.Description = description;
            this.DefaultPaymentMethod = defaultPaymentMethod;
            this.SubscriptionItems = subscriptionItems;
            this.Discounts = discounts;
            this.Metadata = metadata;
        }

            public ResultInfo Result { get; set; }
            public string SubscriptionId { get; set; }
            public string SubscriptionRequestId { get; set; }
            public string CreatedAt { get; set; }
            public string Status { get; set; }
            public string CurrentPeriodStart { get; set; }
            public string CurrentPeriodEnd { get; set; }
            public string BillingCycleAnchor { get; set; }
            public bool? CancelAtPeriodEnd { get; set; }
            public string CanceledAt { get; set; }
            public string TrialStart { get; set; }
            public string TrialEnd { get; set; }
            public BillingSubscriptionInquireDetailsTrialSettings TrialSettings { get; set; }
            public BillingSubscriptionInquireDetailsPauseCollection PauseCollection { get; set; }
            public string CancelAt { get; set; }
            public string CollectionMethod { get; set; }
            public int? DaysUntilDue { get; set; }
            public BillingSubscriptionInquireDetailsCancellationDetails CancellationDetails { get; set; }
            public string TerminationReason { get; set; }
            public string Description { get; set; }
            public string DefaultPaymentMethod { get; set; }
            public List<SubscriptionItem> SubscriptionItems { get; set; }
            public List<Discount> Discounts { get; set; }
            public Dictionary<string, string> Metadata { get; set; }

        

    }

}
