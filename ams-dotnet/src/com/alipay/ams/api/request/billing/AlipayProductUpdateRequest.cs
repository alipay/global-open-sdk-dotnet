using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayProductUpdateRequest : AMSRequest<AlipayProductUpdateResponse>
    {

        public AlipayProductUpdateRequest() { }

        

        public AlipayProductUpdateRequest( string productId , string name , string type , string description , List<string> images , string unitLabel , Dictionary<string, string> metadata , List<string> metadataKeysToRemove , bool? active)
        {
            this.ProductId = productId;
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.Images = images;
            this.UnitLabel = unitLabel;
            this.Metadata = metadata;
            this.MetadataKeysToRemove = metadataKeysToRemove;
            this.Active = active;
        }

            public string ProductId { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
            public List<string> Images { get; set; }
            public string UnitLabel { get; set; }
            public Dictionary<string, string> Metadata { get; set; }
            public List<string> MetadataKeysToRemove { get; set; }
            public bool? Active { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/product/update"; } 


    }

}
