namespace com.alipay.ams.api.entities
{
    public class Discount
    {
        public string DiscountTag { get; set; }
        public string DiscountName { get; set; }
        public Amount SavingsAmount { get; set; }
        public Amount EstimateSavingsAmount { get; set; }
        public  string PromotionCode { get; set; }
    }
}