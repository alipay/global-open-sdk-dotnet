using System.Collections.Generic;
using ams_dotnet.com.alipay.ams.api.response.risk;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.risk;

public class SendRefundResultRequest:AMSRequest<SendRefundResultResponse>
{
    /**
    * A unique ID assigned to a merchant who provides a service or product directly to a customer and is used to identify the transaction.
    * 直接向买家提供服务或商品的商户分配的唯一ID，用于识别交易。
    */
    public string ReferenceTransactionId { get; set; }
    /**
     * A unique ID assigned by the merchant who provides the service or product directly to the buyer to identify the refund.
     * 由直接向买家提供服务或商品的商户分配的识别退款的唯一ID 。
     */
    public string ReferenceRefundId { get; set; }
    /**
     * The total amount of the actual refund.
     * 实际退款总额。
     */
    public Amount ActualRefundAmount { get; set; }
    /**
     * Refund history for this transaction.
     * 本次交易的退款记录。
     */
    public RefundRecord RefundRecords { get; set; }
    
    
    public override string GetRequestURI()
    {
     return AntomPathConstants.RISK_SEND_REFUND_RESULT_PATH;
    }
    
    public override void validate()
    {
           
    }
}