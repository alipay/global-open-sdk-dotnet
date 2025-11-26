using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PeriodRule
    {

        public PeriodRule() { }

        

        public PeriodRule( PeriodType periodType , int? period , Amount price , int? periodCount)
        {
            this.PeriodType = periodType;
            this.Period = period;
            this.Price = price;
            this.PeriodCount = periodCount;
        }

            public PeriodType PeriodType { get; set; }
            public int? Period { get; set; }
            public Amount Price { get; set; }
            public int? PeriodCount { get; set; }

        

    }

}
