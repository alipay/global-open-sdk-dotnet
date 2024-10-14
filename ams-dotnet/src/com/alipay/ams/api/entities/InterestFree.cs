using System.Collections.Generic;

namespace com.alipay.ams.api.entities
{
    public class InterestFree
    {
        public string Provider { get; set; }

        public string ExpireTime { get; set; }

        public List<int> InstallmentFreeNums { get; set; }

        public Amount MinPaymentAmount { get; set; }

        public Amount MaxPaymentAmount { get; set; }

        public int FreePercentage { get; set; }
    }
}