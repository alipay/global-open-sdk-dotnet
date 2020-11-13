

namespace com.alipay.ams.api.entities
{
    public class CreditPayPlan
    {

        public int InstallmentNum { get; set; }


        public CreditPayFeeType CreditPayFeeType { get; set; }


        public int FeePercentage { get; set; }
    }
}
