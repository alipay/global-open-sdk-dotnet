using System;
using System.Collections.Generic;
using System.Text;


namespace com.alipay.ams.api.entities
{
    public class OrderCodeForm
    {

        public String PaymentMethodType { get; set; }


        public String ExpireTime { get; set; }


        public List<CodeDetail> CodeDetails { get; set; }


        public String ExtendInfo { get; set; }
    }
}
