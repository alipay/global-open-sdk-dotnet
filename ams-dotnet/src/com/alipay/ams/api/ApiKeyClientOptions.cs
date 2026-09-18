using System;

namespace com.alipay.ams.api
{
    /// <summary>Optional settings for ordinary API Key requests.</summary>
    public sealed class ApiKeyClientOptions
    {
        /// <summary>Total request timeout. Must be positive and finite.</summary>
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(30);
    }
}
