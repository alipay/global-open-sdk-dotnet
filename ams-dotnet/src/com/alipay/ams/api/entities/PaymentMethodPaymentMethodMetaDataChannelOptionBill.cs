using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentMethodPaymentMethodMetaDataChannelOptionBill
    {

        public PaymentMethodPaymentMethodMetaDataChannelOptionBill() { }

        

        public PaymentMethodPaymentMethodMetaDataChannelOptionBill( string channelPromotionCode)
        {
            this.ChannelPromotionCode = channelPromotionCode;
        }

            public string ChannelPromotionCode { get; set; }

        

    }

}
