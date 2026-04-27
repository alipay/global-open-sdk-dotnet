using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TransferFromDetail
    {

        public TransferFromDetail() { }

        

        public TransferFromDetail( Amount transferFromAmount)
        {
            this.TransferFromAmount = transferFromAmount;
        }

            public Amount TransferFromAmount { get; set; }

        

    }

}
