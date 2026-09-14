using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquireCardTransactionLifecycleDetailResponse : AMSResponse
    {

        public AlipayInquireCardTransactionLifecycleDetailResponse() { }

        

        public AlipayInquireCardTransactionLifecycleDetailResponse( Result result , CardTransactionLifecycleDetail lifecycle)
        {
            this.Result = result;
            this.Lifecycle = lifecycle;
        }

            public Result Result { get; set; }
            public CardTransactionLifecycleDetail Lifecycle { get; set; }

        

    }

}
