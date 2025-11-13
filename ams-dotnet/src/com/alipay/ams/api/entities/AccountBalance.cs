using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AccountBalance
    {

        public AccountBalance() { }

        

        public AccountBalance(  string  accountNo ,  string  currency ,  Amount  availableBalance ,  Amount  frozenBalance ,  Amount  totalBalance)
        {
            this.AccountNo = accountNo;
            this.Currency = currency;
            this.AvailableBalance = availableBalance;
            this.FrozenBalance = frozenBalance;
            this.TotalBalance = totalBalance;
        }

            public  string  AccountNo { get; set; }
            public  string  Currency { get; set; }
            public  Amount  AvailableBalance { get; set; }
            public  Amount  FrozenBalance { get; set; }
            public  Amount  TotalBalance { get; set; }

        

    }

}
