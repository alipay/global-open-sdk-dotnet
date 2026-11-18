using ams_dotnet.com.alipay.ams.api.response.risk;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.risk;

public class SendPaymentResultRequest:AMSRequest<SendPaymentResultResponse>
{
    /**
     * A unique ID assigned to a merchant who provides a service or product directly to a customer and is used to identify the transaction.
     * 直接向买家提供服务或商品的商户分配的唯一ID，用于识别交易。
     */
    public string ReferenceTransactionId { get; set; }
    /**
     * Payment result status. Valid values are as follows:
     * SUCCESS: indicates that the payment is successful.
     * FAIL: indicates that the payment fails.
     * 支付结果状态。有效值为：
     * SUCCESS：表示支付成功。
     * FAIL：表示支付失败。
     */
    public string PaymentStatus { get; set; }
    /**
     * The reason why the card payment authorization provided by the payment method provider failed.
     * 支付方式提供商提供的卡支付授权失败的原因。
     */
    public AuthorizationError AuthorizationError { get; set; }
    /**
     * The result of the verification of the card payment method.
     * 卡支付方式的验证结果。
     */
    public CardVerificationResult CardVerificationResult { get; set; }
    /**
     * Payment method providers.
     * 支付方式提供商。
     */
    public string PaymentMethodProvider { get; set; }
    
    
    public override string GetRequestURI()
    {
     return AntomPathConstants.RISK_SEND_PAYMENT_RESULT_PATH;
    }
    
    public override void validate()
    {
           
    }

}