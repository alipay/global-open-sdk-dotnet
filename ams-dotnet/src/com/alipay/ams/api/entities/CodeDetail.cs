using System;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class CodeDetail
    {
        [JsonPropertyNameAttribute("codeValueType")]
        public CodeValueType CodeValueType { get; set; }

        [JsonPropertyNameAttribute("codeValue")]
        public String CodeValue { get; set; }

        [JsonPropertyNameAttribute("displayType")]
        public DisplayType DisplayType { get; set; }
    }
}
