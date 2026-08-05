using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CreateSubscriptionInfo
    {

        public CreateSubscriptionInfo() { }

        

        public CreateSubscriptionInfo( bool? allowRetry , string retryMode , Amount maxAmountFloor , Amount fixedAmount)
        {
            this.AllowRetry = allowRetry;
            this.RetryMode = retryMode;
            this.MaxAmountFloor = maxAmountFloor;
            this.FixedAmount = fixedAmount;
        }

            public bool? AllowRetry { get; set; }
            public string RetryMode { get; set; }
            public Amount MaxAmountFloor { get; set; }
            public Amount FixedAmount { get; set; }

        

    }

}
