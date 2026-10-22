using System.Collections.Generic;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipayDefenseDocumentNotify : AlipayNotify
{
    /// <summary>Dispute ID.</summary>
    public string DisputeId { get; set; }
    /// <summary>Notification time as an ISO 8601 string with timezone.</summary>
    public string NotifyTime { get; set; }
    /// <summary>Metadata of the generated material; the file body is not included.</summary>
    public DisputeDefenseFile DefenseFile { get; set; }
    /// <summary>Optional predicted win-rate level of this material.</summary>
    public string WinRateLevel { get; set; }
    /// <summary>Optional evidence tags mapped to requirement descriptions.</summary>
    public Dictionary<string, string> RecommendedEvidence { get; set; }
    /// <summary>Optional suggestions for improving the defense material.</summary>
    public string SuggestionsForImprovement { get; set; }
}
