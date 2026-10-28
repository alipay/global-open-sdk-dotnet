using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class FundTransferInfo
    {

        public FundTransferInfo() { }

        

        public FundTransferInfo( string fundTransferType , string sellerMcc , string sellerName , TransferSender transferSender , TransferRecipient transferRecipient)
        {
            this.FundTransferType = fundTransferType;
            this.SellerMcc = sellerMcc;
            this.SellerName = sellerName;
            this.TransferSender = transferSender;
            this.TransferRecipient = transferRecipient;
        }

            public string FundTransferType { get; set; }
            public string SellerMcc { get; set; }
            public string SellerName { get; set; }
            public TransferSender TransferSender { get; set; }
            public TransferRecipient TransferRecipient { get; set; }

        

    }

}
