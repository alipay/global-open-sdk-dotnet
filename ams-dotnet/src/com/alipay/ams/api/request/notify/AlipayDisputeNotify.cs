using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipayDisputeNotify:AlipayNotify
{
    public string PaymentRequestId { get; set; }
    public string DisputeId{ get; set; }
    public string PaymentId{ get; set; }
    public string DisputeTime{ get; set; }
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
    public string disputeType{ get; set; }
    public bool defendable{ get; set; }
}