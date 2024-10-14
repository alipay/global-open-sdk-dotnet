using System;
using System.Collections.Generic;

namespace com.alipay.ams.api.entities
{
    public class PaymentOptionDetail
    {
        public List<SupportCardBrand> SupportCardBrands { get; set; }

        public List<String> Funding { get; set; }

        public List<SupportBank> SupportBanks { get; set; }
    }
}