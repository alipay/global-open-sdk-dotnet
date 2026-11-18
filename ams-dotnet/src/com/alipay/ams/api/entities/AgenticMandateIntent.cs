using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticMandateIntent
    {

        public AgenticMandateIntent() { }

        

        public AgenticMandateIntent( AgenticDeclineThreshold declineThreshold , string effectiveFromTime , string effectiveUntilTime , Merchant preferredMerchant , List<Merchant> allowedMerchant , string consumerPrompt , string intentDesc)
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
            public Merchant PreferredMerchant { get; set; }
            public List<Merchant> AllowedMerchant { get; set; }
            public string ConsumerPrompt { get; set; }
            public string IntentDesc { get; set; }

        

    }

}
