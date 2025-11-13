using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayVaultingSessionResponse : AMSResponse
    {

        public AlipayVaultingSessionResponse() { }

        

        public AlipayVaultingSessionResponse(  Result  result ,  string  vaultingSessionData ,  string  vaultingSessionId ,  string  vaultingSessionExpiryTime)
        {
            this.Result = result;
            this.VaultingSessionData = vaultingSessionData;
            this.VaultingSessionId = vaultingSessionId;
            this.VaultingSessionExpiryTime = vaultingSessionExpiryTime;
        }

            public  Result  Result { get; set; }
            public  string  VaultingSessionData { get; set; }
            public  string  VaultingSessionId { get; set; }
            public  string  VaultingSessionExpiryTime { get; set; }

        

    }

}
