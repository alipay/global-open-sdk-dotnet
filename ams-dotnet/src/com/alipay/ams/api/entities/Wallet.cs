using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Wallet
    {

        public Wallet() { }

        

        public Wallet( string accountNo , UserName accountHolderName , string phoneNo , string email , Address billingAddress , string token , string tokenExpiryTime)
        {
            this.AccountNo = accountNo;
            this.AccountHolderName = accountHolderName;
            this.PhoneNo = phoneNo;
            this.Email = email;
            this.BillingAddress = billingAddress;
            this.Token = token;
            this.TokenExpiryTime = tokenExpiryTime;
        }

            public string AccountNo { get; set; }
            public UserName AccountHolderName { get; set; }
            public string PhoneNo { get; set; }
            public string Email { get; set; }
            public Address BillingAddress { get; set; }
            public string Token { get; set; }
            public string TokenExpiryTime { get; set; }

        

    }

}
