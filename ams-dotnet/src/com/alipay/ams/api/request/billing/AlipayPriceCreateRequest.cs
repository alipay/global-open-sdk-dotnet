using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayPriceCreateRequest : AMSRequest<AlipayPriceCreateResponse>
    {

        public AlipayPriceCreateRequest() { }

        

        public AlipayPriceCreateRequest( string priceRequestId , string productId , string name , string pricingModel , string usageType , Amount unitAmount , string unitLabel , string meterId , RecurringSettings recurring , int? includedQuantity , string tiersMode , List<Tier> tiers , Dictionary<string, string> metadata)
        {
            this.PriceRequestId = priceRequestId;
            this.ProductId = productId;
            this.Name = name;
            this.PricingModel = pricingModel;
            this.UsageType = usageType;
            this.UnitAmount = unitAmount;
            this.UnitLabel = unitLabel;
            this.MeterId = meterId;
            this.Recurring = recurring;
            this.IncludedQuantity = includedQuantity;
            this.TiersMode = tiersMode;
            this.Tiers = tiers;
            this.Metadata = metadata;
        }

            public string PriceRequestId { get; set; }
            public string ProductId { get; set; }
            public string Name { get; set; }
            public string PricingModel { get; set; }
            public string UsageType { get; set; }
            public Amount UnitAmount { get; set; }
            public string UnitLabel { get; set; }
            public string MeterId { get; set; }
            public RecurringSettings Recurring { get; set; }
            public int? IncludedQuantity { get; set; }
            public string TiersMode { get; set; }
            public List<Tier> Tiers { get; set; }
            public Dictionary<string, string> Metadata { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/price/create"; } 


    }

}
