using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CardLimitInfo
    {

        public CardLimitInfo() { }

        

        public CardLimitInfo( string currency , string dailyLimitMax , string monthlyLimitMax , string perTransactionLimitMax , string perCardLimitMax)
        {
            this.Currency = currency;
            this.DailyLimitMax = dailyLimitMax;
            this.MonthlyLimitMax = monthlyLimitMax;
            this.PerTransactionLimitMax = perTransactionLimitMax;
            this.PerCardLimitMax = perCardLimitMax;
        }

            public string Currency { get; set; }
            public string DailyLimitMax { get; set; }
            public string MonthlyLimitMax { get; set; }
            public string PerTransactionLimitMax { get; set; }
            public string PerCardLimitMax { get; set; }

        

    }

}
