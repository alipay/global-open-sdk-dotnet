using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AuthorizationConsultSubscriptionParams
    {

        public AuthorizationConsultSubscriptionParams() { }

        

        public AuthorizationConsultSubscriptionParams( string subscribeTplType , string firstSubscriptionInfo , string followSubscriptionInfos , string originSubscriptionInfo , string targetSubscriptionInfo , string nextPaymentDate , string expireAt , string baseAmount , string offsetAmount , string deductName , string deductDesc)
        {
            this.SubscribeTplType = subscribeTplType;
            this.FirstSubscriptionInfo = firstSubscriptionInfo;
            this.FollowSubscriptionInfos = followSubscriptionInfos;
            this.OriginSubscriptionInfo = originSubscriptionInfo;
            this.TargetSubscriptionInfo = targetSubscriptionInfo;
            this.NextPaymentDate = nextPaymentDate;
            this.ExpireAt = expireAt;
            this.BaseAmount = baseAmount;
            this.OffsetAmount = offsetAmount;
            this.DeductName = deductName;
            this.DeductDesc = deductDesc;
        }

            public string SubscribeTplType { get; set; }
            public string FirstSubscriptionInfo { get; set; }
            public string FollowSubscriptionInfos { get; set; }
            public string OriginSubscriptionInfo { get; set; }
            public string TargetSubscriptionInfo { get; set; }
            public string NextPaymentDate { get; set; }
            public string ExpireAt { get; set; }
            public string BaseAmount { get; set; }
            public string OffsetAmount { get; set; }
            public string DeductName { get; set; }
            public string DeductDesc { get; set; }

        

    }

}
