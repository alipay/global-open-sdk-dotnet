using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CreditPayPlan
    {

        public CreditPayPlan() { }

        

        public CreditPayPlan(  int?  installmentNum ,  string  interval ,  CreditPayFeeType  creditPayFeeType ,  int?  feePercentage)
        {
            this.InstallmentNum = installmentNum;
            this.Interval = interval;
            this.CreditPayFeeType = creditPayFeeType;
            this.FeePercentage = feePercentage;
        }

            public  int?  InstallmentNum { get; set; }
            public  string  Interval { get; set; }
            public  CreditPayFeeType  CreditPayFeeType { get; set; }
            public  int?  FeePercentage { get; set; }

        

    }

}
