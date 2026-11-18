using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AuthorizationConsultDirectDebitInfo
    {

        public AuthorizationConsultDirectDebitInfo() { }

        

        public AuthorizationConsultDirectDebitInfo( string channelProductCode , string personalProductCode , string signScene , AuthorizationAccessParams accessParams , PeriodRuleParams periodRuleParams , AuthorizationConsultPassBackParams passBackParams , AuthorizationConsultSubscriptionParams subscriptionParams , AuthorizationConsultSubMerchant subMerchant , string subscribeType , string oriAgreementNo)
        {
            this.ChannelProductCode = channelProductCode;
            this.PersonalProductCode = personalProductCode;
            this.SignScene = signScene;
            this.AccessParams = accessParams;
            this.PeriodRuleParams = periodRuleParams;
            this.PassBackParams = passBackParams;
            this.SubscriptionParams = subscriptionParams;
            this.SubMerchant = subMerchant;
            this.SubscribeType = subscribeType;
            this.OriAgreementNo = oriAgreementNo;
        }

            public string ChannelProductCode { get; set; }
            public string PersonalProductCode { get; set; }
            public string SignScene { get; set; }
            public AuthorizationAccessParams AccessParams { get; set; }
            public PeriodRuleParams PeriodRuleParams { get; set; }
            public AuthorizationConsultPassBackParams PassBackParams { get; set; }
            public AuthorizationConsultSubscriptionParams SubscriptionParams { get; set; }
            public AuthorizationConsultSubMerchant SubMerchant { get; set; }
            public string SubscribeType { get; set; }
            public string OriAgreementNo { get; set; }

        

    }

}
