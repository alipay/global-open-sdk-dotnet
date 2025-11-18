using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Plan
    {

        public Plan() { }

        

        public Plan( string interestRate , Amount minInstallmentAmount , Amount maxInstallmentAmount , string installmentNum , string interval , bool? enabled)
        {
            this.InterestRate = interestRate;
            this.MinInstallmentAmount = minInstallmentAmount;
            this.MaxInstallmentAmount = maxInstallmentAmount;
            this.InstallmentNum = installmentNum;
            this.Interval = interval;
            this.Enabled = enabled;
        }

            public string InterestRate { get; set; }
            public Amount MinInstallmentAmount { get; set; }
            public Amount MaxInstallmentAmount { get; set; }
            public string InstallmentNum { get; set; }
            public string Interval { get; set; }
            public bool? Enabled { get; set; }

        

    }

}
