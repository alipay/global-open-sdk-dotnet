using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingTrialSettings
    {

        public BillingTrialSettings() { }

        

        public BillingTrialSettings( int? trialPeriodDays , string trialEnd , string trialEndBehavior)
        {
            this.TrialPeriodDays = trialPeriodDays;
            this.TrialEnd = trialEnd;
            this.TrialEndBehavior = trialEndBehavior;
        }

            public int? TrialPeriodDays { get; set; }
            public string TrialEnd { get; set; }
            public string TrialEndBehavior { get; set; }

        

    }

}
