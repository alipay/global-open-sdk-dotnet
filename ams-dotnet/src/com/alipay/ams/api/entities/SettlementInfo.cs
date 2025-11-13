using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class SettlementInfo
    {

        public SettlementInfo() { }

        

        public SettlementInfo(  string  settlementCurrency ,  SettlementBankAccount  settlementBankAccount)
        {
            this.SettlementCurrency = settlementCurrency;
            this.SettlementBankAccount = settlementBankAccount;
        }

            public  string  SettlementCurrency { get; set; }
            public  SettlementBankAccount  SettlementBankAccount { get; set; }

        

    }

}
