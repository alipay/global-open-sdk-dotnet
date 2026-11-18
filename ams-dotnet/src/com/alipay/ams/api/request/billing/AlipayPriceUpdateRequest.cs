using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayPriceUpdateRequest : AMSRequest<AlipayPriceUpdateResponse>
    {

        public AlipayPriceUpdateRequest() { }

        

        public AlipayPriceUpdateRequest( string priceId , string name , string metadata , bool? active , bool? defaultPrice)
        {
            this.PriceId = priceId;
            this.Name = name;
            this.Metadata = metadata;
            this.Active = active;
            this.DefaultPrice = defaultPrice;
        }

            public string PriceId { get; set; }
            public string Name { get; set; }
            public string Metadata { get; set; }
            public bool? Active { get; set; }
            public bool? DefaultPrice { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/price/update"; } 


    }

}
