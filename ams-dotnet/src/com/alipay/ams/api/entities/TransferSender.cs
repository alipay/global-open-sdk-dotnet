using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TransferSender
    {

        public TransferSender() { }

        

        public TransferSender( FundTransferName senderName , FundTransferAddress address)
        {
            this.SenderName = senderName;
            this.Address = address;
        }

            public FundTransferName SenderName { get; set; }
            public FundTransferAddress Address { get; set; }

        

    }

}
