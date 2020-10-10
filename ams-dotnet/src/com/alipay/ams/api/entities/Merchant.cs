using System;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class Merchant
    {

        public Merchant(string merchantName, string referenceMerchantId, string merchantMCC, Store store)
        {
            this.MerchantName = merchantName;
            this.ReferenceMerchantId = referenceMerchantId;
            this.MerchantMCC = merchantMCC;
            this.Store = store;
        }

        [JsonPropertyNameAttribute("referenceMerchantId")]
        public string ReferenceMerchantId { get; internal set; }

        [JsonPropertyNameAttribute("merchantMCC")]
        public string MerchantMCC { get; internal set; }

        [JsonPropertyNameAttribute("merchantName")]
        public string MerchantName { get; internal set; }

        [JsonPropertyNameAttribute("store")]
        public Store Store { get; internal set; }
    }
}
