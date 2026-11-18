using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayPriceInquireDetailsRequest : AMSRequest<AlipayPriceInquireDetailsResponse>
    {

        public AlipayPriceInquireDetailsRequest() { }

        

        public AlipayPriceInquireDetailsRequest( string priceId)
        {
            this.PriceId = priceId;
        }

            public string PriceId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/price/inquireDetails"; } 


    }

}
