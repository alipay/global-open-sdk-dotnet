using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionInquireDetailsTrialSettingsEndBehavior
    {

        public BillingSubscriptionInquireDetailsTrialSettingsEndBehavior() { }

        

        public BillingSubscriptionInquireDetailsTrialSettingsEndBehavior( string missingPaymentMethod)
        {
            this.MissingPaymentMethod = missingPaymentMethod;
        }

            public string MissingPaymentMethod { get; set; }

        

    }

}
