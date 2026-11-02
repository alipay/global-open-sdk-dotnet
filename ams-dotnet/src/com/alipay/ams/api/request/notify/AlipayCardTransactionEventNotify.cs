using System.Collections.Generic;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

/// <summary>
/// One flat ABA VCC card transaction event callback (notification profile v2.1, document v2.13).
/// Verify the raw-body signature before parsing; the merchant handles eventId deduplication and ACK.
/// Amount values remain quoted minor-unit strings of up to 20 digits.
/// </summary>
public class AlipayCardTransactionEventNotify
{
    /// <summary>Stable event ID and the only callback idempotency key. Required; maximum 64 characters.</summary>
    public string EventId { get; set; }

    /// <summary>Spend-group ID shared with inquiry. Required; maximum 64 characters.</summary>
    public string LifecycleId { get; set; }

    /// <summary>Required event type: AUTH, AUTH_CANCEL, CAPTURE, REFUND, CHARGEBACK or REPAYMENT. Preserve unknown future values.</summary>
    public string EventType { get; set; }

    /// <summary>Optional ISO 8601 time of the channel-correlated authorization, maximum 32 characters. Omitted for AUTH or when unavailable; never inferred from transactionTime or authExpireTime.</summary>
    public string AuthTime { get; set; }

    /// <summary>Optional ISO 8601 authorization expiry time, maximum 32 characters. Sent only for AUTH when available.</summary>
    public string AuthExpireTime { get; set; }

    /// <summary>Optional AUTH or PRE_AUTH, maximum 32 characters. Sent only for AUTH when available.</summary>
    public string AuthType { get; set; }

    /// <summary>Optional network approval code, maximum 64 characters. Sent only for AUTH when available.</summary>
    public string AuthCode { get; set; }

    /// <summary>Optional Antom-normalized failure code, maximum 64 characters. Sent only for FAIL when a mapped code exists.</summary>
    public string FailureReason { get; set; }

    /// <summary>Required terminal status: SUCCESS or FAIL. CAPTURE is SUCCESS-only. The accepted status never changes.</summary>
    public string Status { get; set; }

    /// <summary>ANTOM_BIZ_ACCOUNT or ANTOM_FUND_ACCOUNT, maximum 32 characters. Required with a directional amount; CAPTURE sends ANTOM_BIZ_ACCOUNT.</summary>
    public string BalanceType { get; set; }

    /// <summary>Required business-event time in ISO 8601 format with timezone; maximum 32 characters.</summary>
    public string TransactionTime { get; set; }

    /// <summary>Required CARD_PAYMENT for AUTH, CAPTURE and REPAYMENT, or CARD_REFUND for AUTH_CANCEL, REFUND and CHARGEBACK.</summary>
    public string BillType { get; set; }

    /// <summary>Required for successful AUTH, CAPTURE and REPAYMENT. CAPTURE carries value "0" and billing currency, not another debit; omitted otherwise.</summary>
    public Amount OutAmount { get; set; }

    /// <summary>Optional billing-currency inflow for successful AUTH_CANCEL, REFUND or CHARGEBACK when available. Omitted for CAPTURE.</summary>
    public Amount InAmount { get; set; }

    /// <summary>Optional BASE/QUOTE currency pair, maximum 8 characters. Sent with exchangeRate for a cross-currency transaction when both are available.</summary>
    public string ExchangeCurrencyPair { get; set; }

    /// <summary>Optional positive quoted decimal string, maximum 32 characters. One major BASE unit equals this many QUOTE units; paired with exchangeCurrencyPair.</summary>
    public string ExchangeRate { get; set; }

    /// <summary>Required current-event amount in original transaction currency. For CAPTURE this is the captured amount, not the zero additional outflow.</summary>
    public Amount TransactionAmount { get; set; }

    /// <summary>Required merchant-owned card asset ID; maximum 32 characters.</summary>
    public string AssetId { get; set; }

    /// <summary>Optional PCI-safe card mask exposing at most the last four digits; maximum 32 characters.</summary>
    public string MaskedCardNo { get; set; }

    /// <summary>Optional original-transaction program code matching ^[A-Z0-9]{3}$. Extensible string, not a fixed enum or rebate rate; later card-profile changes do not rewrite it.</summary>
    public string CardProduct { get; set; }

    /// <summary>Optional approved merchant context. Name maximum 256 characters, region exactly 2 and mcc exactly 4; parent omitted when no child is available.</summary>
    public EventMerchantInfo MerchantInfo { get; set; }

    /// <summary>Optional approved context: at most 30 entries, keys at most 32 characters, values at most 128 and serialized JSON at most 3096. No key is approved in notification profile v2.1, so it is omitted.</summary>
    public Dictionary<string, string> Metadata { get; set; }

}
