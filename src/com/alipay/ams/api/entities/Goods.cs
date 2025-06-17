    
namespace com.alipay.ams.api.entities
{

public class Goods
    {

        public Goods() { }

        public Goods( string referenceGoodsId , string goodsName , string goodsCategory , string goodsBrand , Amount goodsUnitAmount , string goodsQuantity , string goodsSkuName , string goodsUrl , string deliveryMethodType , string goodsImageUrl , string priceId)
        {
            this.ReferenceGoodsId = referenceGoodsId;
            this.GoodsName = goodsName;
            this.GoodsCategory = goodsCategory;
            this.GoodsBrand = goodsBrand;
            this.GoodsUnitAmount = goodsUnitAmount;
            this.GoodsQuantity = goodsQuantity;
            this.GoodsSkuName = goodsSkuName;
            this.GoodsUrl = goodsUrl;
            this.DeliveryMethodType = deliveryMethodType;
            this.GoodsImageUrl = goodsImageUrl;
            this.PriceId = priceId;
        }

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

        

    }

}
