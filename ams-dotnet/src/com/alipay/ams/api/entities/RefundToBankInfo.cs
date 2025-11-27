using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class RefundToBankInfo
    {

        public RefundToBankInfo() { }

        

        public RefundToBankInfo( string bankCode , UserName accountHolderName , string accountNo)
        {
            this.BankCode = bankCode;
            this.AccountHolderName = accountHolderName;
            this.AccountNo = accountNo;
        }

            public string BankCode { get; set; }
            public UserName AccountHolderName { get; set; }
            public string AccountNo { get; set; }

        

    }

}
