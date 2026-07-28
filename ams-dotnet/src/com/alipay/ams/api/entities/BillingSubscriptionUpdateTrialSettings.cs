using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionUpdateTrialSettings
    {

        public BillingSubscriptionUpdateTrialSettings() { }

        

        public BillingSubscriptionUpdateTrialSettings( string trialEnd , BillingSubscriptionUpdateTrialSettingsEndBehavior endBehavior)
        {
            this.TrialEnd = trialEnd;
            this.EndBehavior = endBehavior;
        }

            public string TrialEnd { get; set; }
            public BillingSubscriptionUpdateTrialSettingsEndBehavior EndBehavior { get; set; }

        

    }

}
