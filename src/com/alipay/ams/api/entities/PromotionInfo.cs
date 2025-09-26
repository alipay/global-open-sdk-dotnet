    
namespace com.alipay.ams.api.entities
{

public class PromotionInfo
    {

        public PromotionInfo() { }

        public PromotionInfo( PromotionType promotionType , Discount discount , InterestFree interestFree)
        {
            this.PromotionType = promotionType;
            this.Discount = discount;
            this.InterestFree = interestFree;
        }

            public PromotionType PromotionType { get; set; }
            public Discount Discount { get; set; }
            public InterestFree InterestFree { get; set; }

        

    }

}
