using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayVaultingQueryRequest : AMSRequest<AlipayVaultingQueryResponse>
    {

        public AlipayVaultingQueryRequest() { }

        

        public AlipayVaultingQueryRequest( string vaultingRequestId , string merchantAccountId)
        {
            this.VaultingRequestId = vaultingRequestId;
            this.MerchantAccountId = merchantAccountId;
        }

            public string VaultingRequestId { get; set; }
            public string MerchantAccountId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/vaults/inquireVaulting"; } 


    }

}
