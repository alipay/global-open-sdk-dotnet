using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentOptionDetail
    {

        public PaymentOptionDetail() { }

        

        public PaymentOptionDetail(  List<SupportCardBrand>  supportCardBrands ,  List<string>  funding ,  List<SupportBank>  supportBanks)
        {
            this.SupportCardBrands = supportCardBrands;
            this.Funding = funding;
            this.SupportBanks = supportBanks;
        }

            public  List<SupportCardBrand>  SupportCardBrands { get; set; }
            public  List<string>  Funding { get; set; }
            public  List<SupportBank>  SupportBanks { get; set; }

        

    }

}
