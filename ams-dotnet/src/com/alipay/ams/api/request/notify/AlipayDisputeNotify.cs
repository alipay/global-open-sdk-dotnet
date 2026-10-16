using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipayDisputeNotify:AlipayNotify
{
    public string PaymentRequestId { get; set; }
    public string DisputeId{ get; set; }
    public string PaymentId{ get; set; }
    public string DisputeTime{ get; set; }
    /// <summary>Optional ISO 8601 cancellation time with timezone, returned for DISPUTE_CANCELLED.</summary>
    public string DisputeCancelledTime { get; set; }
    /// <summary>Optional ISO 8601 defense acceptance time with timezone, returned for DEFENSE_SUPPLIED.</summary>
    public string DefenseSuppliedTime { get; set; }
    public Amount DisputeAmount{ get; set; }
    public DisputeNotificationType DisputeNotificationType{ get; set; }
    public string DisputeReasonMsg{ get; set; }
    public string DisputeJudgedTime{ get; set; }
    public Amount DisputeJudgedAmount{ get; set; }
    public DisputeJudgedResult DisputeJudgedResult{ get; set; }
    public string DefenseDueTime{ get; set; }
    public string DisputeReasonCode{ get; set; }
    public string DisputeSource{ get; set; }
    public string Arn{ get; set; }
    public DisputeAcceptReasonType DisputeAcceptReason{ get; set; }
    public string DisputeAcceptTime { get; set; }
    public string DisputeType{ get; set; }
    public bool Defendable{ get; set; }
    public string CaptureId { get; set; }
    public string AutoDefendReason { get; set; }
    public AcquirerInfo AcquirerInfo { get; set; }
    public IssuerComments IssuerComments { get; set; }

}
