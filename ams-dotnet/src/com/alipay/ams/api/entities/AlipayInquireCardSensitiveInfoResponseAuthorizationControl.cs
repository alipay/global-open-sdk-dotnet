using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AlipayInquireCardSensitiveInfoResponseAuthorizationControl
    {

        public AlipayInquireCardSensitiveInfoResponseAuthorizationControl() { }

        

        public AlipayInquireCardSensitiveInfoResponseAuthorizationControl( CardLimitInfo cardLimitInfo)
        {
            this.CardLimitInfo = cardLimitInfo;
        }

            public CardLimitInfo CardLimitInfo { get; set; }

        

    }

}
