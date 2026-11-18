using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Discount
    {

        public Discount() { }

        

        public Discount( string discountTag , string discountName , Amount savingsAmount , Amount estimateSavingsAmount)
        {
            this.DiscountTag = discountTag;
            this.DiscountName = discountName;
            this.SavingsAmount = savingsAmount;
            this.EstimateSavingsAmount = estimateSavingsAmount;
        }

            public string DiscountTag { get; set; }
            public string DiscountName { get; set; }
            public Amount SavingsAmount { get; set; }
            public Amount EstimateSavingsAmount { get; set; }

        

    }

}
