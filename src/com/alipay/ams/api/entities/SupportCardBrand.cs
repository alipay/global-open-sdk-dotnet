    
namespace com.alipay.ams.api.entities
{

public class SupportCardBrand
    {

        public SupportCardBrand() { }

        public SupportCardBrand( string cardBrand , Logo logo)
        {
            this.CardBrand = cardBrand;
            this.Logo = logo;
        }

            public string CardBrand { get; set; }
            public Logo Logo { get; set; }

        

    }

}
