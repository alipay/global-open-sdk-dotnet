using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayTaxRegisterRequest : AMSRequest<AlipayTaxRegisterResponse>
    {

        public AlipayTaxRegisterRequest() { }

        

        public AlipayTaxRegisterRequest( string registrationRequestId , string taxType , TaxJurisdiction jurisdiction , string registrationType , string taxId , string activeFrom , string expireAt)
        {
            this.RegistrationRequestId = registrationRequestId;
            this.TaxType = taxType;
            this.Jurisdiction = jurisdiction;
            this.RegistrationType = registrationType;
            this.TaxId = taxId;
            this.ActiveFrom = activeFrom;
            this.ExpireAt = expireAt;
        }

            public string RegistrationRequestId { get; set; }
            public string TaxType { get; set; }
            public TaxJurisdiction Jurisdiction { get; set; }
            public string RegistrationType { get; set; }
            public string TaxId { get; set; }
            public string ActiveFrom { get; set; }
            public string ExpireAt { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/tax/register"; } 


    }

}
