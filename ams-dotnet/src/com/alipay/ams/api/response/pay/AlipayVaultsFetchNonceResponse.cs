using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayVaultsFetchNonceResponse : AMSResponse
    {

        public AlipayVaultsFetchNonceResponse() { }

        

        public AlipayVaultsFetchNonceResponse( string cardToken , Result result)
        {
            this.CardToken = cardToken;
            this.Result = result;
        }

            public string CardToken { get; set; }
            public Result Result { get; set; }

        

    }

}
