using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticPaymentTokenOrder
    {

        public AgenticPaymentTokenOrder() { }

        

        public AgenticPaymentTokenOrder( AgenticAmount paymentAmount , AgenticPaymentTokenOrderMerchant merchant , List<AgenticPaymentTokenOrderGoods> goods , string referenceOrderId)
        {
            this.PaymentAmount = paymentAmount;
            this.Merchant = merchant;
            this.Goods = goods;
            this.ReferenceOrderId = referenceOrderId;
        }

            public AgenticAmount PaymentAmount { get; set; }
            public AgenticPaymentTokenOrderMerchant Merchant { get; set; }
            public List<AgenticPaymentTokenOrderGoods> Goods { get; set; }
            public string ReferenceOrderId { get; set; }

        

    }

}
