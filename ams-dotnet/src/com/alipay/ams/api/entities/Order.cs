using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class Order
    {
        [JsonPropertyNameAttribute("referenceOrderId")]
        public string ReferenceOrderId { get; set; }

        [JsonPropertyNameAttribute("orderDescription")]
        public string OrderDescription { get; set; }

        [JsonPropertyNameAttribute("orderAmount")]
        public Amount OrderAmount { get; set; }

        [JsonPropertyNameAttribute("merchant")]
        public Merchant Merchant { get; set; }

        [JsonPropertyNameAttribute("env")]
        public Env Env { get; set; }
    }
}