using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PeriodRule
    {

        public PeriodRule() { }

        

        public PeriodRule( PeriodType periodType , int? periodCount)
        {
            this.PeriodType = periodType;
            this.PeriodCount = periodCount;
        }

            public PeriodType PeriodType { get; set; }
            public int? PeriodCount { get; set; }

        

    }

}
