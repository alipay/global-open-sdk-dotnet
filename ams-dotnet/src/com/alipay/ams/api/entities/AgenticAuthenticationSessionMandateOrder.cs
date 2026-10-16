using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticAuthenticationSessionMandateOrder
    {

        public AgenticAuthenticationSessionMandateOrder() { }

        

        public AgenticAuthenticationSessionMandateOrder( AgenticAmount paymentAmount , AgenticAuthenticationSessionMandateOrderMerchant merchant , List<AgenticSessionGoods> goods , string checkoutJwt , string referenceOrderId)
        {
            this.PaymentAmount = paymentAmount;
            this.Merchant = merchant;
            this.Goods = goods;
            this.CheckoutJwt = checkoutJwt;
            this.ReferenceOrderId = referenceOrderId;
        }

            public AgenticAmount PaymentAmount { get; set; }
            public AgenticAuthenticationSessionMandateOrderMerchant Merchant { get; set; }
            public List<AgenticSessionGoods> Goods { get; set; }
            public string CheckoutJwt { get; set; }
            public string ReferenceOrderId { get; set; }

        

    }

}
