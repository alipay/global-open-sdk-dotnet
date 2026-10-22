namespace com.alipay.ams.api.entities;

public class DisputeEvidenceRecommendation
{
    /// <summary>Evidence tag.</summary>
    public string EvidenceTag { get; set; }
    /// <summary>Whether Antom has already obtained this evidence.</summary>
    public bool? Obtained { get; set; }
    /// <summary>Optional contribution level: HIGH, MEDIUM or LOW.</summary>
    public string WinRateContribution { get; set; }
}
