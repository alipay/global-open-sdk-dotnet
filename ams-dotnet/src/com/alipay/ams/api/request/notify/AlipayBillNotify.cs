using System.Collections.Generic;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

/// <summary>
/// 交易账单状态通知
/// </summary>
public class AlipayBillNotify
{
    /// <summary>
    /// 卡资产ID
    /// </summary>
    public string AssetId { get; set; }

    /// <summary>
    /// 脱敏卡号
    /// </summary>
    public string MaskedCardNo { get; set; }

    /// <summary>
    /// 订单编号
    /// </summary>
    public string OrderNo { get; set; }

    /// <summary>
    /// 由用户定义的卡昵称，可以帮助用户更方便地管理多张万里付卡
    /// </summary>
    public string CardNickName { get; set; }

    /// <summary>
    /// 交易单的创建时间，遵循 ISO 8601 标准格式。例如：“2019-11-27T12:01:01+08:00”
    /// </summary>
    public string TransactionTime { get; set; }

    /// <summary>
    /// 商户名称
    /// </summary>
    public string MerchantName { get; set; }

    /// <summary>
    /// 交易金额
    /// </summary>
    public Amount TradeAmount { get; set; }

    /// <summary>
    /// 下单后流入万里付卡账户的金额，如：退款
    /// </summary>
    public Amount InAmount { get; set; }

    /// <summary>
    /// 下单后流出万里付卡账户的金额
    /// </summary>
    public Amount OutAmount { get; set; }

    /// <summary>
    /// 汇率值。公式：exchangeRate = outAmount / tradeAmount。
    /// 当 outAmount.currency 与 tradeAmount.currency 相同时，此字段恒为 "1"
    /// </summary>
    public string ExchangeRate { get; set; }

    /// <summary>
    /// 交易类型。当前默认取值为 CARD_PAYMENT
    /// </summary>
    public string BillType { get; set; }

    /// <summary>
    /// 代表交易所在国家/地区的二字母 ISO-3166 代码
    /// </summary>
    public string TradeCountry { get; set; }

    /// <summary>
    /// 账单状态。可取值：
    /// WAITING_CLEARANCE, SUCCESS, FAILED, REFUNDED, CANCELLED,
    /// PARTIAL_CANCEL, PARTIAL_REFUND, WAITING_DEDUCT
    /// </summary>
    public string BillStatus { get; set; }

    /// <summary>
    /// 交易失败原因
    /// </summary>
    public FailReason BillFailReason { get; set; }

    /// <summary>
    /// 最后一次更新时间，遵循 ISO 8601 标准格式
    /// </summary>
    public string LastUpdate { get; set; }

    /// <summary>
    /// 客户元数据，键值对格式。
    /// Key 最大长度 32，Value 最大长度 128，最多 30 对，整体 JSON 最大 3096 字符
    /// </summary>
    public Dictionary<string, string> Metadata { get; set; }
}
