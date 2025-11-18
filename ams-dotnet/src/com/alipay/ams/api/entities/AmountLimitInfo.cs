using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AmountLimitInfo
    {

        public AmountLimitInfo() { }

        

        public AmountLimitInfo( AmountLimit singleLimit , AmountLimit dayLimit , AmountLimit monthLimit)
        {
            this.SingleLimit = singleLimit;
            this.DayLimit = dayLimit;
            this.MonthLimit = monthLimit;
        }

            public AmountLimit SingleLimit { get; set; }
            public AmountLimit DayLimit { get; set; }
            public AmountLimit MonthLimit { get; set; }

        

    }

}
