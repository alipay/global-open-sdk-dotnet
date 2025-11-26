using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Order
    {

        public Order() { }

        

        public Order( string referenceOrderId , string orderDescription , Amount orderAmount , Amount orderDiscountAmount , Amount subTotalOrderAmount , Merchant merchant , List<Goods> goods , Shipping shipping , Buyer buyer , Env env , string extendInfo , Transit transit , Lodging lodging , Gaming gaming , bool? needDeclaration , Declaration declaration , string orderType)
        {
            this.ReferenceOrderId = referenceOrderId;
            this.OrderDescription = orderDescription;
            this.OrderAmount = orderAmount;
            this.OrderDiscountAmount = orderDiscountAmount;
            this.SubTotalOrderAmount = subTotalOrderAmount;
            this.Merchant = merchant;
            this.Goods = goods;
            this.Shipping = shipping;
            this.Buyer = buyer;
            this.Env = env;
            this.ExtendInfo = extendInfo;
            this.Transit = transit;
            this.Lodging = lodging;
            this.Gaming = gaming;
            this.NeedDeclaration = needDeclaration;
            this.Declaration = declaration;
            this.OrderType = orderType;
        }

            public string ReferenceOrderId { get; set; }
            public string OrderDescription { get; set; }
            public Amount OrderAmount { get; set; }
            public Amount OrderDiscountAmount { get; set; }
            public Amount SubTotalOrderAmount { get; set; }
            public Merchant Merchant { get; set; }
            public List<Goods> Goods { get; set; }
            public Shipping Shipping { get; set; }
            public Buyer Buyer { get; set; }
            public Env Env { get; set; }
            public string ExtendInfo { get; set; }
            public Transit Transit { get; set; }
            public Lodging Lodging { get; set; }
            public Gaming Gaming { get; set; }
            public bool? NeedDeclaration { get; set; }
            public Declaration Declaration { get; set; }
            public string OrderType { get; set; }

        

    }

}
