using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class FundTransferRecipient
    {

        public FundTransferRecipient() { }

        

        public FundTransferRecipient( FundTransferName recipientName , FundTransferAddress address , string recipientAccountNumber)
        {
            this.RecipientName = recipientName;
            this.Address = address;
            this.RecipientAccountNumber = recipientAccountNumber;
        }

            public FundTransferName RecipientName { get; set; }
            public FundTransferAddress Address { get; set; }
            public string RecipientAccountNumber { get; set; }

        

    }

}
