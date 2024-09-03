using System;

namespace com.alipay.ams.api.entities
{
    public class Plan
    {
        public string InterestRate { get; set; }

        public Amount MinInstallmentAmount { get; set; }

        public Amount MaxInstallmentAmount { get; set; }

        public string InstallmentNum { get; set; }

        public string Interval { get; set; }

        public Boolean Enabled { get; set; }
    }
}