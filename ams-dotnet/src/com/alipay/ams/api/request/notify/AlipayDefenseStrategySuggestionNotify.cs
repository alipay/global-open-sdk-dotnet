using System.Collections.Generic;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipayDefenseStrategySuggestionNotify : AlipayNotify
{
    /// <summary>Dispute ID.</summary>
    public string DisputeId { get; set; }
    /// <summary>Notification time as an ISO 8601 string with timezone.</summary>
    public string NotifyTime { get; set; }
    /// <summary>Predicted win-rate level: HIGH, MEDIUM or LOW.</summary>
    public string WinRateLevel { get; set; }
    /// <summary>Recommended evidence items, from 1 to 32 entries.</summary>
    public List<DisputeEvidenceRecommendation> EvidenceList { get; set; }
    /// <summary>Optional cardholder dispute reason.</summary>
    public string CardholderDisputeReason { get; set; }
    /// <summary>Suggested defense strategy.</summary>
    public string DefenseStrategyDescription { get; set; }
}
