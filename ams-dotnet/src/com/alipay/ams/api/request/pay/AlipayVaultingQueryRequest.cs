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

        

        public AlipayVaultingQueryRequest(  string  vaultingRequestId)
        {
            this.VaultingRequestId = vaultingRequestId;
        }

            public  string  VaultingRequestId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/vaults/inquireVaulting"; } 


    }

}
