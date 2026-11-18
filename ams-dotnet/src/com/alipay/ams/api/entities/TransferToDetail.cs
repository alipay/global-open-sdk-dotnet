using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TransferToDetail
    {

        public TransferToDetail() { }

        

        public TransferToDetail( PaymentMethod transferToMethod , string transferToCurrency , Amount feeAmount , Amount actualTransferToAmount , string purposeCode , string transferNotifyUrl , string transferRemark)
        {
            this.TransferToMethod = transferToMethod;
            this.TransferToCurrency = transferToCurrency;
            this.FeeAmount = feeAmount;
            this.ActualTransferToAmount = actualTransferToAmount;
            this.PurposeCode = purposeCode;
            this.TransferNotifyUrl = transferNotifyUrl;
            this.TransferRemark = transferRemark;
        }

            public PaymentMethod TransferToMethod { get; set; }
            public string TransferToCurrency { get; set; }
            public Amount FeeAmount { get; set; }
            public Amount ActualTransferToAmount { get; set; }
            public string PurposeCode { get; set; }
            public string TransferNotifyUrl { get; set; }
            public string TransferRemark { get; set; }

        

    }

}
