using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentOption
    {

        public PaymentOption() { }

        

        public PaymentOption(  string  paymentMethodType ,  PaymentMethodCategoryType  paymentMethodCategory ,  List<string>  paymentMethodRegion ,  bool?  enabled ,  bool?  preferred ,  string  disableReason ,  Dictionary<string, AmountLimit>  amountLimitInfoMap ,  List<string>  supportedCurrencies ,  PaymentOptionDetail  paymentOptionDetail ,  string  extendInfo ,  Logo  logo ,  List<string>  promoNames ,  Installment  installment ,  List<PromotionInfo>  promotionInfos)
        {
            this.PaymentMethodType = paymentMethodType;
            this.PaymentMethodCategory = paymentMethodCategory;
            this.PaymentMethodRegion = paymentMethodRegion;
            this.Enabled = enabled;
            this.Preferred = preferred;
            this.DisableReason = disableReason;
            this.AmountLimitInfoMap = amountLimitInfoMap;
            this.SupportedCurrencies = supportedCurrencies;
            this.PaymentOptionDetail = paymentOptionDetail;
            this.ExtendInfo = extendInfo;
            this.Logo = logo;
            this.PromoNames = promoNames;
            this.Installment = installment;
            this.PromotionInfos = promotionInfos;
        }

            public  string  PaymentMethodType { get; set; }
            public  PaymentMethodCategoryType  PaymentMethodCategory { get; set; }
            public  List<string>  PaymentMethodRegion { get; set; }
            public  bool?  Enabled { get; set; }
            public  bool?  Preferred { get; set; }
            public  string  DisableReason { get; set; }
            public  Dictionary<string, AmountLimit>  AmountLimitInfoMap { get; set; }
            public  List<string>  SupportedCurrencies { get; set; }
            public  PaymentOptionDetail  PaymentOptionDetail { get; set; }
            public  string  ExtendInfo { get; set; }
            public  Logo  Logo { get; set; }
            public  List<string>  PromoNames { get; set; }
            public  Installment  Installment { get; set; }
            public  List<PromotionInfo>  PromotionInfos { get; set; }

        

    }

}
