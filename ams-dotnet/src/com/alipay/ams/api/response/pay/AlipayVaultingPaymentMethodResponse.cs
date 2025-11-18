using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayVaultingPaymentMethodResponse : AMSResponse
    {

        public AlipayVaultingPaymentMethodResponse() { }

        

        public AlipayVaultingPaymentMethodResponse( Result result , string vaultingRequestId , PaymentMethodDetail paymentMethodDetail , string normalUrl , string schemeUrl , string applinkUrl)
        {
            this.Result = result;
            this.VaultingRequestId = vaultingRequestId;
            this.PaymentMethodDetail = paymentMethodDetail;
            this.NormalUrl = normalUrl;
            this.SchemeUrl = schemeUrl;
            this.ApplinkUrl = applinkUrl;
        }

            public Result Result { get; set; }
            public string VaultingRequestId { get; set; }
            public PaymentMethodDetail PaymentMethodDetail { get; set; }
            public string NormalUrl { get; set; }
            public string SchemeUrl { get; set; }
            public string ApplinkUrl { get; set; }

        

    }

}
