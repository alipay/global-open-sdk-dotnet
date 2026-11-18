using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CardholderInfo
    {

        public CardholderInfo() { }

        

        public CardholderInfo( UserName cardHolderName , Address billAddress , string displayName)
        {
            this.CardHolderName = cardHolderName;
            this.BillAddress = billAddress;
            this.DisplayName = displayName;
        }

            public UserName CardHolderName { get; set; }
            public Address BillAddress { get; set; }
            public string DisplayName { get; set; }

        

    }

}
