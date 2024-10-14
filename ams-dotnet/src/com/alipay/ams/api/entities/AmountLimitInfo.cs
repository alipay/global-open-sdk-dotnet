namespace com.alipay.ams.api.entities
{
    public class AmountLimitInfo
    {
        public AmountLimit SingleLimit { get; set; }
        public AmountLimit DayLimit { get; set; }
        public AmountLimit MonthLimit { get; set; }
    }
}