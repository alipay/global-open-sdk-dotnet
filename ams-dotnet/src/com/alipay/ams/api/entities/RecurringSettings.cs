using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class RecurringSettings
    {

        public RecurringSettings() { }

        

        public RecurringSettings( PeriodRule periodRule)
        {
            this.PeriodRule = periodRule;
        }

            public PeriodRule PeriodRule { get; set; }

        

    }

}
