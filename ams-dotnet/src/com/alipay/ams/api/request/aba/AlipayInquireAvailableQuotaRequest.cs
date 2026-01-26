using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquireAvailableQuotaRequest : AMSRequest<AlipayInquireAvailableQuotaResponse>
    {

        public AlipayInquireAvailableQuotaRequest() { }

        

        public AlipayInquireAvailableQuotaRequest( string currency)
        {
            this.Currency = currency;
        }

            public string Currency { get; set; }

        public override string GetRequestURI(){ return "/ams/v1/aba/account/inquireAvailableQuota"; } 


    }

}
