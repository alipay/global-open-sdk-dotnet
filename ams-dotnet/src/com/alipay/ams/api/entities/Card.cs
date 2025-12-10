using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Card
    {

        public Card() { }

        

        public Card( string cardNo , string cvv , string expiryYear , string expiryMonth , UserName cardholderName)
        {
            this.CardNo = cardNo;
            this.Cvv = cvv;
            this.ExpiryYear = expiryYear;
            this.ExpiryMonth = expiryMonth;
            this.CardholderName = cardholderName;
        }

            public string CardNo { get; set; }
            public string Cvv { get; set; }
            public string ExpiryYear { get; set; }
            public string ExpiryMonth { get; set; }
            public UserName CardholderName { get; set; }

        

    }

}
