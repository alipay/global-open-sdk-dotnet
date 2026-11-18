using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionTrialSettingsEndBehavior
    {

        public BillingSubscriptionTrialSettingsEndBehavior() { }

        

        public BillingSubscriptionTrialSettingsEndBehavior( string missingPaymentMethod)
        {
            this.MissingPaymentMethod = missingPaymentMethod;
        }

            public string MissingPaymentMethod { get; set; }

        

    }

}
