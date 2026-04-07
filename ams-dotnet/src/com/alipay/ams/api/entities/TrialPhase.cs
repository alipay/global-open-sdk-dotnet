using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TrialPhase
    {

        public TrialPhase() { }

        

        public TrialPhase( int? phaseNo , Amount trialAmount)
        {
            this.PhaseNo = phaseNo;
            this.TrialAmount = trialAmount;
        }

            public int? PhaseNo { get; set; }
            public Amount TrialAmount { get; set; }

        

    }

}
