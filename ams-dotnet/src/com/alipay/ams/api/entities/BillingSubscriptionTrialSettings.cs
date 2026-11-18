using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionTrialSettings
    {

        public BillingSubscriptionTrialSettings() { }

        

        public BillingSubscriptionTrialSettings( BillingSubscriptionTrialSettingsEndBehavior endBehavior)
        {
            this.EndBehavior = endBehavior;
        }

            public BillingSubscriptionTrialSettingsEndBehavior EndBehavior { get; set; }

        

    }

}
