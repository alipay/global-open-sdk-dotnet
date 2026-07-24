using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayPriceUpdateResponse : AMSResponse
    {

        public AlipayPriceUpdateResponse() { }

        

        public AlipayPriceUpdateResponse( Result result , string priceId , string productId , string name , string pricingModel , string usageType , string unitLabel , string meterId , Amount unitAmount , RecurringSettings recurring , bool? active , int? includedQuantity , string tiersMode , List<Tier> tiers , Dictionary<string, string> metadata , string createdAt , string deactivatedAt , string updatedAt)
        {
            this.Result = result;
            this.PriceId = priceId;
            this.ProductId = productId;
            this.Name = name;
            this.PricingModel = pricingModel;
            this.UsageType = usageType;
            this.UnitLabel = unitLabel;
            this.MeterId = meterId;
            this.UnitAmount = unitAmount;
            this.Recurring = recurring;
            this.Active = active;
            this.IncludedQuantity = includedQuantity;
            this.TiersMode = tiersMode;
            this.Tiers = tiers;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.DeactivatedAt = deactivatedAt;
            this.UpdatedAt = updatedAt;
        }

            public Result Result { get; set; }
            public string PriceId { get; set; }
            public string ProductId { get; set; }
            public string Name { get; set; }
            public string PricingModel { get; set; }
            public string UsageType { get; set; }
            public string UnitLabel { get; set; }
            public string MeterId { get; set; }
            public Amount UnitAmount { get; set; }
            public RecurringSettings Recurring { get; set; }
            public bool? Active { get; set; }
            public int? IncludedQuantity { get; set; }
            public string TiersMode { get; set; }
            public List<Tier> Tiers { get; set; }
            public Dictionary<string, string> Metadata { get; set; }
            public string CreatedAt { get; set; }
            public string DeactivatedAt { get; set; }
            public string UpdatedAt { get; set; }

        

    }

}
