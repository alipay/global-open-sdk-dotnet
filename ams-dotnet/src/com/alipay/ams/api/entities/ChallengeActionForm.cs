using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ChallengeActionForm
    {

        public ChallengeActionForm() { }

        

        public ChallengeActionForm( ChallengeType challengeType , string challengeRenderValue , ChallengeTriggerSourceType triggerSource , string extendInfo)
        {
            this.ChallengeType = challengeType;
            this.ChallengeRenderValue = challengeRenderValue;
            this.TriggerSource = triggerSource;
            this.ExtendInfo = extendInfo;
        }

            public ChallengeType ChallengeType { get; set; }
            public string ChallengeRenderValue { get; set; }
            public ChallengeTriggerSourceType TriggerSource { get; set; }
            public string ExtendInfo { get; set; }

        

    }

}
