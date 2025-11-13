using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class SettlementBankAccount
    {

        public SettlementBankAccount() { }

        

        public SettlementBankAccount(  string  bankAccountNo ,  string  accountHolderName ,  string  swiftCode ,  string  bankRegion ,  AccountHolderType  accountHolderType ,  string  routingNumber ,  string  branchCode ,  string  accountHolderTIN ,  AccountType  accountType ,  string  bankName ,  Address  accountHolderAddress ,  string  iban)
        {
            this.BankAccountNo = bankAccountNo;
            this.AccountHolderName = accountHolderName;
            this.SwiftCode = swiftCode;
            this.BankRegion = bankRegion;
            this.AccountHolderType = accountHolderType;
            this.RoutingNumber = routingNumber;
            this.BranchCode = branchCode;
            this.AccountHolderTIN = accountHolderTIN;
            this.AccountType = accountType;
            this.BankName = bankName;
            this.AccountHolderAddress = accountHolderAddress;
            this.Iban = iban;
        }

            public  string  BankAccountNo { get; set; }
            public  string  AccountHolderName { get; set; }
            public  string  SwiftCode { get; set; }
            public  string  BankRegion { get; set; }
            public  AccountHolderType  AccountHolderType { get; set; }
            public  string  RoutingNumber { get; set; }
            public  string  BranchCode { get; set; }
            public  string  AccountHolderTIN { get; set; }
            public  AccountType  AccountType { get; set; }
            public  string  BankName { get; set; }
            public  Address  AccountHolderAddress { get; set; }
            public  string  Iban { get; set; }

        

    }

}
