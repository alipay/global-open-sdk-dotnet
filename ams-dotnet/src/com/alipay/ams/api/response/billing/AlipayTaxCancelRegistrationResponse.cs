using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayTaxCancelRegistrationResponse : AMSResponse
    {

        public AlipayTaxCancelRegistrationResponse() { }

        

        public AlipayTaxCancelRegistrationResponse( Result result , string taxRegistrationId , string taxType , TaxJurisdiction jurisdiction , string registrationType , string taxId , string status , string activeFrom , string expireAt)
        {
            this.Result = result;
            this.TaxRegistrationId = taxRegistrationId;
            this.TaxType = taxType;
            this.Jurisdiction = jurisdiction;
            this.RegistrationType = registrationType;
            this.TaxId = taxId;
            this.Status = status;
            this.ActiveFrom = activeFrom;
            this.ExpireAt = expireAt;
        }

            public Result Result { get; set; }
            public string TaxRegistrationId { get; set; }
            public string TaxType { get; set; }
            public TaxJurisdiction Jurisdiction { get; set; }
            public string RegistrationType { get; set; }
            public string TaxId { get; set; }
            public string Status { get; set; }
            public string ActiveFrom { get; set; }
            public string ExpireAt { get; set; }

        

    }

}
