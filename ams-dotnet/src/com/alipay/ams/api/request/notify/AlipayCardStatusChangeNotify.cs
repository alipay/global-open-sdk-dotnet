namespace com.alipay.ams.api.request.notify;

/// <summary>
/// 卡状态变更通知
/// </summary>
public class AlipayCardStatusChangeNotify
{
    /// <summary>
    /// 针对本次申卡请求，由集成商指定的唯一请求号（用于幂等性）
    /// </summary>
    public string RequestId { get; set; }

    /// <summary>
    /// 卡资产ID
    /// </summary>
    public string AssetId { get; set; }

    /// <summary>
    /// 操作类型：ADD / FREEZE / UNFREEZE / CANCEL
    /// </summary>
    public string OperateType { get; set; }

    /// <summary>
    /// 操作结果：SUCCESS / FAIL
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// 卡状态：ACTIVE（可正常使用）、FROZEN（已冻结）、CANCEL（已注销）
    /// </summary>
    public string CardStatus { get; set; }

    /// <summary>
    /// 创建时间，UTC 时间，ISO 8601 格式，例如：2018-10-31T00:00:00+0800
    /// </summary>
    public string CreatedTime { get; set; }

    /// <summary>
    /// 更新时间，UTC 时间，ISO 8601 格式
    /// </summary>
    public string UpdatedTime { get; set; }

    /// <summary>
    /// 卡组织品牌，当前阶段默认为 MASTERCARD
    /// </summary>
    public string CardBrand { get; set; }

    /// <summary>
    /// 卡类型：VIRTUAL / PHYSICAL
    /// </summary>
    public string CardType { get; set; }
}