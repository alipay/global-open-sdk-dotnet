using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class FundTransferSender
    {

        public FundTransferSender() { }

        

        public FundTransferSender( FundTransferPartyName senderName , FundTransferPartyAddress address)
        {
            this.SenderName = senderName;
            this.Address = address;
        }

            public FundTransferPartyName SenderName { get; set; }
            public FundTransferPartyAddress Address { get; set; }

        

    }

}
