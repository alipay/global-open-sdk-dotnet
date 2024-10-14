using System.Collections.Generic;

namespace com.alipay.ams.api.entities
{
    public class Installment
    {
        public List<SupportCardBrand> SupportCardBrands { get; set; }

        public List<Plan> Plans { get; set; }
    }
}