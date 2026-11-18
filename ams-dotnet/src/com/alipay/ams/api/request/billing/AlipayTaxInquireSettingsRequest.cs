using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayTaxInquireSettingsRequest : AMSRequest<AlipayTaxInquireSettingsResponse>
    {

        public AlipayTaxInquireSettingsRequest() { }

        

        public override string GetRequestURI(){ return "/ams/api/v1/tax/inquireSettings"; } 


    }

}
