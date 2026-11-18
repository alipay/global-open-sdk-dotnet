using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayTaxInquireSettingsResponse : AMSResponse
    {

        public AlipayTaxInquireSettingsResponse() { }

        

        public AlipayTaxInquireSettingsResponse( Result result , string defaultTaxCode , string defaultTaxBehavior , TaxHeadOffice headOffice , string status)
        {
            this.Result = result;
            this.DefaultTaxCode = defaultTaxCode;
            this.DefaultTaxBehavior = defaultTaxBehavior;
            this.HeadOffice = headOffice;
            this.Status = status;
        }

            public Result Result { get; set; }
            public string DefaultTaxCode { get; set; }
            public string DefaultTaxBehavior { get; set; }
            public TaxHeadOffice HeadOffice { get; set; }
            public string Status { get; set; }

        

    }

}
