using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentMethodPaymentMethodMetaData
    {

        public PaymentMethodPaymentMethodMetaData() { }

        

        public PaymentMethodPaymentMethodMetaData( PaymentMethodPaymentMethodMetaDataChannelOptionBill channelOptionBill)
        {
            this.ChannelOptionBill = channelOptionBill;
        }

            public PaymentMethodPaymentMethodMetaDataChannelOptionBill ChannelOptionBill { get; set; }

        

    }

}
