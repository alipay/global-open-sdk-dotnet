using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayVaultingQueryResponse : AMSResponse
    {

        public AlipayVaultingQueryResponse() { }

        

        public AlipayVaultingQueryResponse( Result result , string vaultingRequestId , string normalUrl , string schemeUrl , string applinkUrl , string vaultingStatus , PaymentMethodDetail paymentMethodDetail , string metadata)
        {
            this.Result = result;
            this.VaultingRequestId = vaultingRequestId;
            this.NormalUrl = normalUrl;
            this.SchemeUrl = schemeUrl;
            this.ApplinkUrl = applinkUrl;
            this.VaultingStatus = vaultingStatus;
            this.PaymentMethodDetail = paymentMethodDetail;
            this.Metadata = metadata;
        }

            public Result Result { get; set; }
            public string VaultingRequestId { get; set; }
            public string NormalUrl { get; set; }
            public string SchemeUrl { get; set; }
            public string ApplinkUrl { get; set; }
            public string VaultingStatus { get; set; }
            public PaymentMethodDetail PaymentMethodDetail { get; set; }
            public string Metadata { get; set; }

        

    }

}
