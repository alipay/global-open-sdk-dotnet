using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayBillingSubscriptionUpdateRequest : AMSRequest<AlipayBillingSubscriptionUpdateResponse>
    {

        public AlipayBillingSubscriptionUpdateRequest() { }

        

        public AlipayBillingSubscriptionUpdateRequest( string subscriptionId , List<PriceItemChange> priceItemChanges , string prorationBehavior , string prorationDate , BillingSubscriptionUpdatePauseCollection pauseCollection , string billingCycleAnchor , BillingSubscriptionUpdateTrialSettings trialSettings , bool? cancelAtPeriodEnd , string collectionMethod , int? daysUntilDue , string defaultPaymentMethod , string description , Dictionary<string, string> metadata)
        {
            this.SubscriptionId = subscriptionId;
            this.PriceItemChanges = priceItemChanges;
            this.ProrationBehavior = prorationBehavior;
            this.ProrationDate = prorationDate;
            this.PauseCollection = pauseCollection;
            this.BillingCycleAnchor = billingCycleAnchor;
            this.TrialSettings = trialSettings;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.CollectionMethod = collectionMethod;
            this.DaysUntilDue = daysUntilDue;
            this.DefaultPaymentMethod = defaultPaymentMethod;
            this.Description = description;
            this.Metadata = metadata;
        }

            public string SubscriptionId { get; set; }
            public List<PriceItemChange> PriceItemChanges { get; set; }
            public string ProrationBehavior { get; set; }
            public string ProrationDate { get; set; }
            public BillingSubscriptionUpdatePauseCollection PauseCollection { get; set; }
            public string BillingCycleAnchor { get; set; }
            public BillingSubscriptionUpdateTrialSettings TrialSettings { get; set; }
            public bool? CancelAtPeriodEnd { get; set; }
            public string CollectionMethod { get; set; }
            public int? DaysUntilDue { get; set; }
            public string DefaultPaymentMethod { get; set; }
            public string Description { get; set; }
            public Dictionary<string, string> Metadata { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/subscription/update"; } 


    }

}
