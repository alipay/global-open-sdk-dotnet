namespace com.alipay.ams.api.entities
{
    public class PromotionInfo
    {
        public PromotionType PromotionType { get; set; }

        public Discount Discount { get; set; }

        public InterestFree InterestFree { get; set; }
    }
}