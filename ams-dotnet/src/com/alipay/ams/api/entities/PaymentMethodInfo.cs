using System;

namespace com.alipay.ams.api.entities
{
    public class PaymentMethodInfo
    {
        public string PaymentMethodType { get; set; }
        public string PaymentMethodDetail { get; set; }
        public Boolean Enabled { get; set; }
        public Boolean Preferred { get; set; }
        public string ExtendInfo { get; set; }
    }
}