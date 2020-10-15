using System;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class Store
    {

        public Store(string storeName, string referenceStoreId, string storeMCC)
        {
            this.ReferenceStoreId = referenceStoreId;
            this.StoreName = storeName;
            this.StoreMCC = storeMCC;
        }

        [JsonPropertyNameAttribute("referenceStoreId")]
        public string ReferenceStoreId { get; internal set; }

        [JsonPropertyNameAttribute("storeName")]
        public string StoreName { get; internal set; }

        [JsonPropertyNameAttribute("storeMCC")]
        public string StoreMCC { get; internal set; }
    }
}
