    
namespace com.alipay.ams.api.entities
{

public class PromotionResult
    {

        public PromotionResult() { }

        public PromotionResult( PromotionType promotionType , Discount discount)
        {
            this.PromotionType = promotionType;
            this.Discount = discount;
        }

            public PromotionType PromotionType { get; set; }
            public Discount Discount { get; set; }

        

    }

}
