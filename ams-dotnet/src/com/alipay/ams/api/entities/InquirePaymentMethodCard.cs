using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class InquirePaymentMethodCard
    {

        public InquirePaymentMethodCard() { }

        

        public InquirePaymentMethodCard( string cardToken , string cardNo , string mask , string brand , string countryIssue , string cardIssuer , string expiryMonth , string expiryYear , UserName instUserName , Address billingAddress)
        {
            this.CardToken = cardToken;
            this.CardNo = cardNo;
            this.Mask = mask;
            this.Brand = brand;
            this.CountryIssue = countryIssue;
            this.CardIssuer = cardIssuer;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            this.InstUserName = instUserName;
            this.BillingAddress = billingAddress;
        }

            public string CardToken { get; set; }
            public string CardNo { get; set; }
            public string Mask { get; set; }
            public string Brand { get; set; }
            public string CountryIssue { get; set; }
            public string CardIssuer { get; set; }
            public string ExpiryMonth { get; set; }
            public string ExpiryYear { get; set; }
            public UserName InstUserName { get; set; }
            public Address BillingAddress { get; set; }

        

    }

}
