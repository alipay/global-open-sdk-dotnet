using System.Collections.Generic;
using ams_dotnet.com.alipay.ams.api.response.risk;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.risk;

public class RiskDecideRequest : AMSRequest<RiskDecideResponse>
{
    /**
    * A unique ID assigned to a merchant who provides a service or product directly to a customer and is used to identify the transaction.
    * 直接向买家提供服务或商品的商户分配的唯一ID，用于识别交易。
    */
    public string ReferenceTransactionId  { get; set; }
    /**
     * The stage at which the API is called. Valid values are as follows:
     * PRE_AUTHORIZATION: Indicates that you initiated this call before the card payment was authorized.
     * POST_AUTHORIZATION : Indicates that you initiated this call after the card payment was authorized
     * 调用 API 的阶段。有效值为：
     * PRE_AUTHORIZATION：表示您在卡支付授权之前发起此请求。
     * POST_AUTHORIZATION ：表示您在卡支付授权后发起此请求。
     */
    public AuthorizationPhase AuthorizationPhase { get; set; }
    /**
     * Order information, including merchant, product, amount, and shipping information.
     * 订单信息，包括商户、商品、金额和运输信息等。
     */
    public Order[] Orders { get; set; }
    /**
     * Buyer information, including the buyer's ID, name, phone number, email, etc.
     * 买家信息，包括买家的 ID、姓名、电话号码和电子邮件等。
     */
    public Buyer Buyer { get; set; }
    /**
     * The amount that the buyer actually needs to pay after deducting the discount.
     * 扣除折扣后买家实际需要支付的金额。
     */
    public Amount ActualPaymentAmount { get; set; }
    /**
     * Payment method details, including payment method type, card information, etc.
     * 支付方式详细信息，包括支付方式类型、卡信息等。
     */
    public PaymentDetail[] PaymentDetails { get; set; }
    /**
     * The amount of the discount for this transaction.
     * 本次交易的折扣金额。
     */
    public Amount DiscountAmount { get; set; }
    /**
     * Information about the environment in which the order was placed, such as device information.
     * 下单环境信息，例如设备信息。
     */
    public Env Env { get; set; }
    
    public override string GetRequestURI()
    {
     return AntomPathConstants.RISK_DECIDE_PATH;
    }
    
    public override void validate()
    {
           
    }

}