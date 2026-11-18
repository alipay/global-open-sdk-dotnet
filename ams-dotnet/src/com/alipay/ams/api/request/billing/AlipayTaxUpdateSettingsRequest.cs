using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayTaxUpdateSettingsRequest : AMSRequest<AlipayTaxUpdateSettingsResponse>
    {

        public AlipayTaxUpdateSettingsRequest() { }

        

        public AlipayTaxUpdateSettingsRequest( string settingsUpdateRequestId , string defaultTaxCode , string defaultTaxBehavior , TaxHeadOffice headOffice)
        {
            this.SettingsUpdateRequestId = settingsUpdateRequestId;
            this.DefaultTaxCode = defaultTaxCode;
            this.DefaultTaxBehavior = defaultTaxBehavior;
            this.HeadOffice = headOffice;
        }

            public string SettingsUpdateRequestId { get; set; }
            public string DefaultTaxCode { get; set; }
            public string DefaultTaxBehavior { get; set; }
            public TaxHeadOffice HeadOffice { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/tax/updateSettings"; } 


    }

}
