using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticBindingSessionMandateIntent
    {

        public AgenticBindingSessionMandateIntent() { }

        

        public AgenticBindingSessionMandateIntent( AgenticDeclineThreshold declineThreshold , string effectiveFromTime , string effectiveUntilTime , AgenticPreferredMerchant preferredMerchant , List<AgenticAllowedMerchant> allowedMerchant , string consumerPrompt , string intentDesc)
        {
            this.DeclineThreshold = declineThreshold;
            this.EffectiveFromTime = effectiveFromTime;
            this.EffectiveUntilTime = effectiveUntilTime;
            this.PreferredMerchant = preferredMerchant;
            this.AllowedMerchant = allowedMerchant;
            this.ConsumerPrompt = consumerPrompt;
            this.IntentDesc = intentDesc;
        }

            public AgenticDeclineThreshold DeclineThreshold { get; set; }
            public string EffectiveFromTime { get; set; }
            public string EffectiveUntilTime { get; set; }
            public AgenticPreferredMerchant PreferredMerchant { get; set; }
            public List<AgenticAllowedMerchant> AllowedMerchant { get; set; }
            public string ConsumerPrompt { get; set; }
            public string IntentDesc { get; set; }

        

    }

}
