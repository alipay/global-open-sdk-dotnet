

namespace com.alipay.ams.api.entities
{
    public class Order
    {

        public string ReferenceOrderId { get; set; }


        public string OrderDescription { get; set; }


        public Amount OrderAmount { get; set; }


        public Merchant Merchant { get; set; }


        public Env Env { get; set; }
    }
}