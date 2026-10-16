using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticPaymentTokenOrderGoods
    {

        public AgenticPaymentTokenOrderGoods() { }

        

        public AgenticPaymentTokenOrderGoods( string referenceGoodsId , string goodsName , AgenticAmount goodsUnitAmount , string goodsQuantity , string goodsUrl , string goodsCategory)
        {
            this.ReferenceGoodsId = referenceGoodsId;
            this.GoodsName = goodsName;
            this.GoodsUnitAmount = goodsUnitAmount;
            this.GoodsQuantity = goodsQuantity;
            this.GoodsUrl = goodsUrl;
            this.GoodsCategory = goodsCategory;
        }

            public string ReferenceGoodsId { get; set; }
            public string GoodsName { get; set; }
            public AgenticAmount GoodsUnitAmount { get; set; }
            public string GoodsQuantity { get; set; }
            public string GoodsUrl { get; set; }
            public string GoodsCategory { get; set; }

        

    }

}
