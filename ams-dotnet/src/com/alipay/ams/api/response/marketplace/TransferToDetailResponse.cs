using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.marketplace
{

public class TransferToDetailResponse : AMSResponse
    {

        public TransferToDetailResponse() { }

        

        public TransferToDetailResponse( PaymentMethod transferToMethod , Amount transferToAmount , Amount feeAmount)
        {
            this.TransferToMethod = transferToMethod;
            this.TransferToAmount = transferToAmount;
            this.FeeAmount = feeAmount;
        }

            public PaymentMethod TransferToMethod { get; set; }
            public Amount TransferToAmount { get; set; }
            public Amount FeeAmount { get; set; }

        

    }

}
