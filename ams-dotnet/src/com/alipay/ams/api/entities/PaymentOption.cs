using System;
using System.Collections.Generic;

namespace com.alipay.ams.api.entities
{
    public class PaymentOption
    {
        public string PaymentMethodType { get; set; }
        public PaymentMethodCategoryType PaymentMethodCategory { get; set; }
        public List<string> PaymentMethodRegion { get; set; }
        public Boolean Enabled { get; set; }
        public Boolean Preferred { get; set; }
        public string DisableReason { get; set; }
        public Dictionary<string, AmountLimitInfo> DmountLimitInfoMap { get; set; }
        public List<string> SupportedCurrencies { get; set; }
        public PaymentOptionDetail PaymentOptionDetail { get; set; }
        public string ExtendInfo { get; set; }
        public Logo Logo { get; set; }
        public List<string> PromoNames { get; set; }

        public Installment Installment { get; set; }
        public List<PromotionInfo> PromotionInfos { get; set; }
    }
}