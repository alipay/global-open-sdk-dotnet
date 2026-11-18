using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayVaultsFetchNonceRequest : AMSRequest<AlipayVaultsFetchNonceResponse>
    {

        public AlipayVaultsFetchNonceRequest() { }

        

        public AlipayVaultsFetchNonceRequest( Card card)
        {
            this.Card = card;
        }

            public Card Card { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/vaults/fetchNonce"; } 


    }

}
