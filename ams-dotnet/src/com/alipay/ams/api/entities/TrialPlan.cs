using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TrialPlan
    {

        public TrialPlan() { }

        

        public TrialPlan( string trialEndTime , int? freeTrialDays , List<TrialPhase> phases)
        {
            this.TrialEndTime = trialEndTime;
            this.FreeTrialDays = freeTrialDays;
            this.Phases = phases;
        }

            public string TrialEndTime { get; set; }
            public int? FreeTrialDays { get; set; }
            public List<TrialPhase> Phases { get; set; }

        

    }

}
