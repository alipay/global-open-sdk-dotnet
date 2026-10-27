using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class FundTransferSender
    {

        public FundTransferSender() { }

        

        public FundTransferSender( FundTransferSenderName senderName , FundTransferAddress address)
        {
            this.SenderName = senderName;
            this.Address = address;
        }

            public FundTransferSenderName SenderName { get; set; }
            public FundTransferAddress Address { get; set; }

        

    }

}
