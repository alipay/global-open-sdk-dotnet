    
namespace com.alipay.ams.api.entities
{

public class PaymentMethodTypeItem
    {

        public PaymentMethodTypeItem() { }

        public PaymentMethodTypeItem( string paymentMethodType , string paymentMethodOrder , string expressCheckout)
        {
            this.PaymentMethodType = paymentMethodType;
            this.PaymentMethodOrder = paymentMethodOrder;
            this.ExpressCheckout = expressCheckout;
        }

            public string PaymentMethodType { get; set; }
            public string PaymentMethodOrder { get; set; }
            public string ExpressCheckout { get; set; }

        

    }

}
