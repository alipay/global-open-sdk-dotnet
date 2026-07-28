using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayTaxInitializeSettingsRequest : AMSRequest<AlipayTaxInitializeSettingsResponse>
    {

        public AlipayTaxInitializeSettingsRequest() { }

        

        public AlipayTaxInitializeSettingsRequest( string settingsRequestId , string defaultTaxCode , string defaultTaxBehavior , TaxHeadOffice headOffice)
        {
            this.SettingsRequestId = settingsRequestId;
            this.DefaultTaxCode = defaultTaxCode;
            this.DefaultTaxBehavior = defaultTaxBehavior;
            this.HeadOffice = headOffice;
        }

            public string SettingsRequestId { get; set; }
            public string DefaultTaxCode { get; set; }
            public string DefaultTaxBehavior { get; set; }
            public TaxHeadOffice HeadOffice { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/tax/initializeSettings"; } 


    }

}
