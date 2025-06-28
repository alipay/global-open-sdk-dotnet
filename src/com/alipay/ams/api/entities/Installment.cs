    
namespace com.alipay.ams.api.entities
{

public class Installment
    {

        public Installment() { }

        public Installment( List<SupportCardBrand> supportCardBrands , List<Plan> plans)
        {
            this.SupportCardBrands = supportCardBrands;
            this.Plans = plans;
        }

            public List<SupportCardBrand> SupportCardBrands { get; set; }
            public List<Plan> Plans { get; set; }

        

    }

}
