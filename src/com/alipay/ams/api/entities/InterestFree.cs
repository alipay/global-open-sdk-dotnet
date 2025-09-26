    
namespace com.alipay.ams.api.entities
{

public class InterestFree
    {

        public InterestFree() { }

        public InterestFree( string provider , string expireTime , List<int?> installmentFreeNums , Amount minPaymentAmount , Amount maxPaymentAmount , int? freePercentage)
        {
            this.Provider = provider;
            this.ExpireTime = expireTime;
            this.InstallmentFreeNums = installmentFreeNums;
            this.MinPaymentAmount = minPaymentAmount;
            this.MaxPaymentAmount = maxPaymentAmount;
            this.FreePercentage = freePercentage;
        }

            public string Provider { get; set; }
            public string ExpireTime { get; set; }
            public List<int?> InstallmentFreeNums { get; set; }
            public Amount MinPaymentAmount { get; set; }
            public Amount MaxPaymentAmount { get; set; }
            public int? FreePercentage { get; set; }

        

    }

}
