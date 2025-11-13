using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class SupportBank
    {

        public SupportBank() { }

        

        public SupportBank(  string  bankIdentifierCode ,  string  bankShortName ,  Logo  bankLogo)
        {
            this.BankIdentifierCode = bankIdentifierCode;
            this.BankShortName = bankShortName;
            this.BankLogo = bankLogo;
        }

            public  string  BankIdentifierCode { get; set; }
            public  string  BankShortName { get; set; }
            public  Logo  BankLogo { get; set; }

        

    }

}
