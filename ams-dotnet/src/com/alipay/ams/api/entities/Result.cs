using System;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class Result
    {
        public Result() { }

        [JsonPropertyNameAttribute("resultCode")]
        public string ResultCode { get; set; }

        [JsonPropertyNameAttribute("resultMessage")]
        public string ResultMessage { get; set; }

        [JsonPropertyNameAttribute("resultStatus")]
        public string ResultStatus { get; set; }
    }
}
