using ams_dotnet.com.alipay.ams.api.response.risk;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.risk;

public class RiskReportRequest:AMSRequest<RiskReportResponse>
{
    /**
    * A unique ID assigned to a merchant who provides a service or product directly to a customer and is used to identify the transaction.
    * 直接向买家提供服务或商品的商户分配的唯一ID，用于识别交易。
    */
    public string ReferenceTransactionId { get; set; }
    /**
     * The reason for the report.Providing this information can help improve the accuracy of fraud detection, and increase payment success
     * rates.
     * 上报的原因,提供这些信息有助于提升欺诈检测的准确性，提高支付成功率。
     */
    public string ReportReason { get; set; }
    /**
     * The type of risk reported. Valid values are as follows:
     * SUSPICIOUS: indicates that the transaction is considered risky by the merchant, such as the buyer hit the merchant's blacklist.
     * CHARGEBACK: indicates that the buyer initiated a chargeback.
     * FRAUD: indicates that fraudulent card fraud has occurred.
     * 上报的风险类型。有效值为：
     * SUSPICIOUS：表示该交易被商户视为有风险，例如买家命中了商户的黑名单。
     * CHARGEBACK：表示买家发起了拒付。
     * FRAUD：表示发生了卡盗刷行为。
     */
    public string RiskType { get; set; }
    /**
     * Represents the time when a risk event occurs, defined as follows:
     * If the riskType value is SUSPICIOUS, the value of this field is the time when you identified the risky transaction.
     * If the value of riskType is CHARGEBACK, the value of this field is the time when the chargeback occurred included in the
     * notification that the payment method sent you.
     * If the value of riskType is FRAUD, the value of this field is the time of the card theft that is included in the notification sent
     * to you by the payment method.
     * 表示风险事件发生的时间，定义如下：
     * 如果 riskType 值为 SUSPICIOUS， 该字段的值为您识别该风险交易的时间。
     * 如果 riskType 的值为 CHARGEBACK，该字段的值为支付方式向您发送的通知中包含的拒付发生时间。
     * 如果 riskType 的值为 FRAUD，该字段的值为支付方式向您发送的通知中包含的盗卡发生时间。
     */
    public string RiskOccurrenceTime { get; set; }
    
    
    public override string GetRequestURI()
    {
     return AntomPathConstants.RISK_REPORT_PATH;
    }
    
    public override void validate()
    {
           
    }


}