using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayTaxCancelRegistrationRequest : AMSRequest<AlipayTaxCancelRegistrationResponse>
    {

        public AlipayTaxCancelRegistrationRequest() { }

        

        public AlipayTaxCancelRegistrationRequest( string registrationCancelRequestId , string taxRegistrationId)
        {
            this.RegistrationCancelRequestId = registrationCancelRequestId;
            this.TaxRegistrationId = taxRegistrationId;
        }

            public string RegistrationCancelRequestId { get; set; }
            public string TaxRegistrationId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/tax/cancelRegistration"; } 


    }

}
