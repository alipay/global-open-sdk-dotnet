using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.marketplace
{

public class TransferFromDetailResponse : AMSResponse
    {

        public TransferFromDetailResponse() { }

        

        public TransferFromDetailResponse( PaymentMethodResponse transferFromMethod , Amount transferFromAmount , Amount feeAmount)
        {
            this.TransferFromMethod = transferFromMethod;
            this.TransferFromAmount = transferFromAmount;
            this.FeeAmount = feeAmount;
        }

            public PaymentMethodResponse TransferFromMethod { get; set; }
            public Amount TransferFromAmount { get; set; }
            public Amount FeeAmount { get; set; }

        

    }

}
