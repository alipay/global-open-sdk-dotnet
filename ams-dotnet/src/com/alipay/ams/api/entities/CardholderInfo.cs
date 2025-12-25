using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CardholderInfo
    {

        public CardholderInfo() { }

        

        public CardholderInfo( UserName cardHolderName , Address billAddress)
        {
            this.CardHolderName = cardHolderName;
            this.BillAddress = billAddress;
        }

            public UserName CardHolderName { get; set; }
            public Address BillAddress { get; set; }

        

    }

}
