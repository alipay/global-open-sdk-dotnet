

using System.Collections.Generic;

namespace com.alipay.ams.api.entities
{
    public class Order
    {

        public string ReferenceOrderId { get; set; }


        public string OrderDescription { get; set; }


        public Amount OrderAmount { get; set; }


        public Merchant Merchant { get; set; }
        
        public List<Goods> Goods { get; set; }
        public Shipping Shipping { get; set; }
        public Buyer Buyer { get; set; }


        public Env Env { get; set; }

        public string ExtendInfo { get; set; }
        
        public Transit Transit { get; set; }
        public Lodging Lodging { get; set; }
        public Gaming Gaming { get; set; }
        public Amount OrderDiscountAmount { get; set; }
        public Amount SubTotalOrderAmount { get; set; }
    }
}