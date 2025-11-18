using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayVaultingSessionRequest : AMSRequest<AlipayVaultingSessionResponse>
    {

        public AlipayVaultingSessionRequest() { }

        

        public AlipayVaultingSessionRequest( string paymentMethodType , string vaultingRequestId , string vaultingNotificationUrl , string redirectUrl , string merchantRegion , bool? is3DSAuthentication)
        {
            this.PaymentMethodType = paymentMethodType;
            this.VaultingRequestId = vaultingRequestId;
            this.VaultingNotificationUrl = vaultingNotificationUrl;
            this.RedirectUrl = redirectUrl;
            this.MerchantRegion = merchantRegion;
            this.Is3DSAuthentication = is3DSAuthentication;
        }

            public string PaymentMethodType { get; set; }
            public string VaultingRequestId { get; set; }
            public string VaultingNotificationUrl { get; set; }
            public string RedirectUrl { get; set; }
            public string MerchantRegion { get; set; }
            public bool? Is3DSAuthentication { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/vaults/createVaultingSession"; } 


    }

}
