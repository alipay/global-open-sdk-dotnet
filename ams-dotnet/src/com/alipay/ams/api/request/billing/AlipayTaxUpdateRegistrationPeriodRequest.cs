using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayTaxUpdateRegistrationPeriodRequest : AMSRequest<AlipayTaxUpdateRegistrationPeriodResponse>
    {

        public AlipayTaxUpdateRegistrationPeriodRequest() { }

        

        public AlipayTaxUpdateRegistrationPeriodRequest( string registrationUpdatePeriodRequestId , string taxRegistrationId , string activeFrom , string expireAt)
        {
            this.RegistrationUpdatePeriodRequestId = registrationUpdatePeriodRequestId;
            this.TaxRegistrationId = taxRegistrationId;
            this.ActiveFrom = activeFrom;
            this.ExpireAt = expireAt;
        }

            public string RegistrationUpdatePeriodRequestId { get; set; }
            public string TaxRegistrationId { get; set; }
            public string ActiveFrom { get; set; }
            public string ExpireAt { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/tax/updateRegistrationPeriod"; } 


    }

}
