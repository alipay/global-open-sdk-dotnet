using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class DiscountPaymentMethodDetail
    {

        public DiscountPaymentMethodDetail() { }

        

        public DiscountPaymentMethodDetail(  string  discountId ,  Amount  availableAmount ,  string  discountName ,  string  discountDescription ,  string  paymentMethodDetailMetadata)
        {
            this.DiscountId = discountId;
            this.AvailableAmount = availableAmount;
            this.DiscountName = discountName;
            this.DiscountDescription = discountDescription;
            this.PaymentMethodDetailMetadata = paymentMethodDetailMetadata;
        }

            public  string  DiscountId { get; set; }
            public  Amount  AvailableAmount { get; set; }
            public  string  DiscountName { get; set; }
            public  string  DiscountDescription { get; set; }
            public  string  PaymentMethodDetailMetadata { get; set; }

        

    }

}
