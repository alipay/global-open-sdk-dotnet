namespace com.alipay.ams.api.entities;

public class RefundRecord
{
    /**
     * A unique ID on the merchant's side that identifies the order and is assigned by the merchant who provides the service or product
     * directly to the customer.
     * 商户侧识别订单的唯一ID，由直接向买家提供服务或商品的商户分配。
     */
    public string ReferenceOrderId { get; set; }
    /**
     * A unique ID that identifies the product.
     * 识别商品的唯一 ID。
     */
    public string ReferenceGoodsId { get; set; }
    /**
     * The amount of the refund for the item.
     * 商品的退款金额。
     */
    public Amount Amount { get; set; }
    /**
     * Refund reason.
     * 退款原因
     */
    public string RefundReason { get; set; }
    /**
     * The date and time when the refund reached the final state of success or failure.
     * 退款达到成功或失败终态的日期和时间。
     */
    public string RefundTime { get; set; }
}