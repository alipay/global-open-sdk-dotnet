namespace com.alipay.ams.api.entities;

public class Goods
{
    public string ReferenceGoodsId { get; set; }
    public string GoodsName { get; set; }
    public string GoodsCategory { get; set; }
    public string GoodsBrand { get; set; }
    public Amount GoodsUnitAmount { get; set; }
    public string GoodsQuantity { get; set; }
    public string GoodsSkuName { get; set; }
    public string GoodsUrl { get; set; }
    public string DeliveryMethodType { get; set; }
    public string GoodsImageUrl { get; set; }
    public string PriceId { get; set; }
    public Amount GoodsDiscountAmount { get; set; }
    public Goods CrossSell { get; set; }
}