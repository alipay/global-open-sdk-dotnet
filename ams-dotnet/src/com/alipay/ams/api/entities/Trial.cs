using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Trial
    {

        public Trial() { }

        

        public Trial( int? trialPeriod , Amount trialAmount , int? trialStartPeriod , int? trialEndPeriod)
        {
            this.TrialPeriod = trialPeriod;
            this.TrialAmount = trialAmount;
            this.TrialStartPeriod = trialStartPeriod;
            this.TrialEndPeriod = trialEndPeriod;
        }

            public int? TrialPeriod { get; set; }
            public Amount TrialAmount { get; set; }
            public int? TrialStartPeriod { get; set; }
            public int? TrialEndPeriod { get; set; }

        

    }

}
