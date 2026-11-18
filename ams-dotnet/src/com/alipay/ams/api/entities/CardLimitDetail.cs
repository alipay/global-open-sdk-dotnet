using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CardLimitDetail
    {

        public CardLimitDetail() { }

        

        public CardLimitDetail( Amount perTransactionLimit , Limit dailyLimit , Limit monthlyLimit , Limit perCardLimit , string dailyLimitMax , string monthlyLimitMax , string perTransactionLimitMax , string perCardLimitMax)
        {
            this.PerTransactionLimit = perTransactionLimit;
            this.DailyLimit = dailyLimit;
            this.MonthlyLimit = monthlyLimit;
            this.PerCardLimit = perCardLimit;
            this.DailyLimitMax = dailyLimitMax;
            this.MonthlyLimitMax = monthlyLimitMax;
            this.PerTransactionLimitMax = perTransactionLimitMax;
            this.PerCardLimitMax = perCardLimitMax;
        }

            public Amount PerTransactionLimit { get; set; }
            public Limit DailyLimit { get; set; }
            public Limit MonthlyLimit { get; set; }
            public Limit PerCardLimit { get; set; }
            public string DailyLimitMax { get; set; }
            public string MonthlyLimitMax { get; set; }
            public string PerTransactionLimitMax { get; set; }
            public string PerCardLimitMax { get; set; }

        

    }

}
