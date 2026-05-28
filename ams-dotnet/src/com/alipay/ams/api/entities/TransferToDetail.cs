using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TransferToDetail
    {

        public TransferToDetail() { }

        

        public TransferToDetail( PaymentMethod transferToMethod , Amount transferToAmount , string transferNotifyUrl , string transferRemark , string transferMemo)
        {
            this.TransferToMethod = transferToMethod;
            this.TransferToAmount = transferToAmount;
            this.TransferNotifyUrl = transferNotifyUrl;
            this.TransferRemark = transferRemark;
            this.TransferMemo = transferMemo;
        }

            public PaymentMethod TransferToMethod { get; set; }
            public Amount TransferToAmount { get; set; }
            public string TransferNotifyUrl { get; set; }
            public string TransferRemark { get; set; }
            public string TransferMemo { get; set; }

        

    }

}
