using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Product
    {

        public Product() { }

        

        public Product( string productId , string name , string type , string description , List<string> images , string unitLabel , Dictionary<string, string> metadata , bool? active , string createdAt , string deactivatedAt , string updatedAt)
        {
            this.ProductId = productId;
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.Images = images;
            this.UnitLabel = unitLabel;
            this.Metadata = metadata;
            this.Active = active;
            this.CreatedAt = createdAt;
            this.DeactivatedAt = deactivatedAt;
            this.UpdatedAt = updatedAt;
        }

            public string ProductId { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
            public List<string> Images { get; set; }
            public string UnitLabel { get; set; }
            public Dictionary<string, string> Metadata { get; set; }
            public bool? Active { get; set; }
            public string CreatedAt { get; set; }
            public string DeactivatedAt { get; set; }
            public string UpdatedAt { get; set; }

        

    }

}
