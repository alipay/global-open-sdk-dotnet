namespace com.alipay.ams.api.entities
{
    public class Discount
    {
        private string DiscountTag { get; set; }
        public string DiscountName { get; set; }
        public Amount SavingsAmount { get; set; }
        private Amount EstimateSavingsAmount { get; set; }
    }
}