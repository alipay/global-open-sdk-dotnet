using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionUpdateTrialSettingsEndBehavior
    {

        public BillingSubscriptionUpdateTrialSettingsEndBehavior() { }

        

        public BillingSubscriptionUpdateTrialSettingsEndBehavior( string missingPaymentMethod)
        {
            this.MissingPaymentMethod = missingPaymentMethod;
        }

            public string MissingPaymentMethod { get; set; }

        

    }

}
