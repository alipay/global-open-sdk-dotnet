using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionInquireDetailsTrialSettings
    {

        public BillingSubscriptionInquireDetailsTrialSettings() { }

        

        public BillingSubscriptionInquireDetailsTrialSettings( BillingSubscriptionInquireDetailsTrialSettingsEndBehavior endBehavior)
        {
            this.EndBehavior = endBehavior;
        }

            public BillingSubscriptionInquireDetailsTrialSettingsEndBehavior EndBehavior { get; set; }

        

    }

}
