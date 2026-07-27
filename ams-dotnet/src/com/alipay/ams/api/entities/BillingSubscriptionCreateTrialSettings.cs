using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionCreateTrialSettings
    {

        public BillingSubscriptionCreateTrialSettings() { }

        

        public BillingSubscriptionCreateTrialSettings( int? trialPeriodDays , string trialEnd)
        {
            this.TrialPeriodDays = trialPeriodDays;
            this.TrialEnd = trialEnd;
        }

            public int? TrialPeriodDays { get; set; }
            public string TrialEnd { get; set; }

        

    }

}
