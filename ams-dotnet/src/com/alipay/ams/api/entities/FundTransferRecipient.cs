using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class FundTransferRecipient
    {

        public FundTransferRecipient() { }

        

        public FundTransferRecipient( FundTransferPartyName recipientName , FundTransferPartyAddress address , string recipientAccountNumber)
        {
            this.RecipientName = recipientName;
            this.Address = address;
            this.RecipientAccountNumber = recipientAccountNumber;
        }

            public FundTransferPartyName RecipientName { get; set; }
            public FundTransferPartyAddress Address { get; set; }
            public string RecipientAccountNumber { get; set; }

        

    }

}
