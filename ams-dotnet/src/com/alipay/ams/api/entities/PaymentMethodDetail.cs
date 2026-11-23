using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentMethodDetail
    {

        public PaymentMethodDetail() { }

        

        public PaymentMethodDetail( PaymentMethodDetailType paymentMethodDetailType , CardPaymentMethodDetail card , ExternalPaymentMethodDetail externalAccount , DiscountPaymentMethodDetail discount , CouponPaymentMethodDetail coupon , string paymentMethodType , string extendInfo , Wallet wallet , string interactionType)
        {
            this.PaymentMethodDetailType = paymentMethodDetailType;
            this.Card = card;
            this.ExternalAccount = externalAccount;
            this.Discount = discount;
            this.Coupon = coupon;
            this.PaymentMethodType = paymentMethodType;
            this.ExtendInfo = extendInfo;
            this.Wallet = wallet;
            this.InteractionType = interactionType;
        }

            public PaymentMethodDetailType PaymentMethodDetailType { get; set; }
            public CardPaymentMethodDetail Card { get; set; }
            public ExternalPaymentMethodDetail ExternalAccount { get; set; }
            public DiscountPaymentMethodDetail Discount { get; set; }
            public CouponPaymentMethodDetail Coupon { get; set; }
            public string PaymentMethodType { get; set; }
            public string ExtendInfo { get; set; }
            public Wallet Wallet { get; set; }
            public string InteractionType { get; set; }

        

    }

}
