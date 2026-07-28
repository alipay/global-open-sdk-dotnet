using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayTaxInquireRegistrationListResponse : AMSResponse
    {

        public AlipayTaxInquireRegistrationListResponse() { }

        

        public AlipayTaxInquireRegistrationListResponse( Result result , List<TaxRegistration> registrations , Paginator paginator)
        {
            this.Result = result;
            this.Registrations = registrations;
            this.Paginator = paginator;
        }

            public Result Result { get; set; }
            public List<TaxRegistration> Registrations { get; set; }
            public Paginator Paginator { get; set; }

        

    }

}
