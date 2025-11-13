using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Trial
    {

        public Trial() { }

        

        public Trial(  int?  trialStartPeriod ,  Amount  trialAmount ,  int?  trialEndPeriod)
        {
            this.TrialStartPeriod = trialStartPeriod;
            this.TrialAmount = trialAmount;
            this.TrialEndPeriod = trialEndPeriod;
        }

            public  int?  TrialStartPeriod { get; set; }
            public  Amount  TrialAmount { get; set; }
            public  int?  TrialEndPeriod { get; set; }

        

    }

}
