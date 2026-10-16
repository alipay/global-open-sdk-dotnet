using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticBindingSessionMandateOrder
    {

        public AgenticBindingSessionMandateOrder() { }

        

        public AgenticBindingSessionMandateOrder( AgenticAmount paymentAmount , AgenticBindingSessionMandateOrderMerchant merchant , List<AgenticSessionGoods> goods , string checkoutJwt , string referenceOrderId)
        {
            this.PaymentAmount = paymentAmount;
            this.Merchant = merchant;
            this.Goods = goods;
            this.CheckoutJwt = checkoutJwt;
            this.ReferenceOrderId = referenceOrderId;
        }

            public AgenticAmount PaymentAmount { get; set; }
            public AgenticBindingSessionMandateOrderMerchant Merchant { get; set; }
            public List<AgenticSessionGoods> Goods { get; set; }
            public string CheckoutJwt { get; set; }
            public string ReferenceOrderId { get; set; }

        

    }

}
