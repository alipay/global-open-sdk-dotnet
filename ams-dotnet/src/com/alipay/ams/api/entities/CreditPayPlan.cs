using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class CreditPayPlan
    {
        [JsonPropertyNameAttribute("installmentNum")]
        public int InstallmentNum { get; set; }

        [JsonPropertyNameAttribute("creditPayFeeType")]
        public CreditPayFeeType CreditPayFeeType { get; set; }

        [JsonPropertyNameAttribute("feePercentage")]
        public int FeePercentage { get; set; }
    }
}
