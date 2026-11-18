using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PeriodRuleParams
    {

        public PeriodRuleParams() { }

        

        public PeriodRuleParams( PeriodType periodType , string period , string singleAmount)
        {
            this.PeriodType = periodType;
            this.Period = period;
            this.SingleAmount = singleAmount;
        }

            public PeriodType PeriodType { get; set; }
            public string Period { get; set; }
            public string SingleAmount { get; set; }

        

    }

}
