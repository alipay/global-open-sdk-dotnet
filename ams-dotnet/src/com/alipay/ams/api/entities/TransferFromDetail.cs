using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TransferFromDetail
    {

        public TransferFromDetail() { }

        

        public TransferFromDetail( PaymentMethod transferFromMethod , Amount transferFromAmount)
        {
            this.TransferFromMethod = transferFromMethod;
            this.TransferFromAmount = transferFromAmount;
        }

            public PaymentMethod TransferFromMethod { get; set; }
            public Amount TransferFromAmount { get; set; }

        

    }

}
