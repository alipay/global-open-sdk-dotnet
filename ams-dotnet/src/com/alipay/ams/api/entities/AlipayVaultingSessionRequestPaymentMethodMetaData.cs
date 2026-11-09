using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AlipayVaultingSessionRequestPaymentMethodMetaData
    {

        public AlipayVaultingSessionRequestPaymentMethodMetaData() { }

        

        public AlipayVaultingSessionRequestPaymentMethodMetaData( string recurringType)
        {
            this.RecurringType = recurringType;
        }

            public string RecurringType { get; set; }

        

    }

}
