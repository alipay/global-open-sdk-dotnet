using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Limit
    {

        public Limit() { }

        

        public Limit( Amount remainingLimit , Amount rangeLimit , Amount usedLimit)
        {
            this.RemainingLimit = remainingLimit;
            this.RangeLimit = rangeLimit;
            this.UsedLimit = usedLimit;
        }

            public Amount RemainingLimit { get; set; }
            public Amount RangeLimit { get; set; }
            public Amount UsedLimit { get; set; }

        

    }

}
