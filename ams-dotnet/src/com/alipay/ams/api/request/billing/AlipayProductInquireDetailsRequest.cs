using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayProductInquireDetailsRequest : AMSRequest<AlipayProductInquireDetailsResponse>
    {

        public AlipayProductInquireDetailsRequest() { }

        

        public AlipayProductInquireDetailsRequest( string productId , bool? includePrices)
        {
            this.ProductId = productId;
            this.IncludePrices = includePrices;
        }

            public string ProductId { get; set; }
            public bool? IncludePrices { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/product/inquireDetails"; } 


    }

}
