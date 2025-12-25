namespace com.alipay.ams.api.entities;
/// <summary>
/// 交易失败原因
/// </summary>
public class FailReason
{
    /// <summary>
    /// 交易失败结果码
    /// </summary>
    public string ErrorCode { get; set; }

    /// <summary>
    /// 交易失败结果信息，对失败结果码的补充说明
    /// </summary>
    public string ErrorDesc { get; set; }
}