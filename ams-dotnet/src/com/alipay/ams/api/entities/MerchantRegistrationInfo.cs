using System;
using System.Collections.Generic;
namespace com.alipay.ams.api.entities
{
    public class MerchantRegistrationInfo
    {
        public string ReferenceMerchantId { get; set; }

        public string MerchantDisplayName { get; set; }

        public string MerchantMCC { get; set; }

        public Logo Logo { get; set; }

        public List<WebSite> Websites { get; set; }

        public Address MerchantAddress { get; set; }

        public RegistrationDetail RegistrationDetail { get; set; }
    }
}
