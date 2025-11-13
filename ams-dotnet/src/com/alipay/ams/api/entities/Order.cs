using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Order
    {

        public Order() { }

        

        public Order(  string  referenceOrderId ,  string  orderDescription ,  Amount  orderAmount ,  Merchant  merchant ,  List<Goods>  goods ,  Shipping  shipping ,  Buyer  buyer ,  Env  env ,  string  extendInfo ,  Transit  transit ,  Lodging  lodging ,  Gaming  gaming ,  bool?  needDeclaration ,  string  orderTest ,  Declaration  declaration ,  string  orderType)
        {
            this.ReferenceOrderId = referenceOrderId;
            this.OrderDescription = orderDescription;
            this.OrderAmount = orderAmount;
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
            this.OrderTest = orderTest;
            this.Declaration = declaration;
            this.OrderType = orderType;
        }

            public  string  ReferenceOrderId { get; set; }
            public  string  OrderDescription { get; set; }
            public  Amount  OrderAmount { get; set; }
            public  Merchant  Merchant { get; set; }
            public  List<Goods>  Goods { get; set; }
            public  Shipping  Shipping { get; set; }
            public  Buyer  Buyer { get; set; }
            public  Env  Env { get; set; }
            public  string  ExtendInfo { get; set; }
            public  Transit  Transit { get; set; }
            public  Lodging  Lodging { get; set; }
            public  Gaming  Gaming { get; set; }
            public  bool?  NeedDeclaration { get; set; }
            public  string  OrderTest { get; set; }
            public  Declaration  Declaration { get; set; }
            public  string  OrderType { get; set; }

        

    }

}
