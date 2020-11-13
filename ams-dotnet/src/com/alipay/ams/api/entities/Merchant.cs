using System;


namespace com.alipay.ams.api.entities
{
    public class Merchant
    {

        public Merchant(string merchantName, string referenceMerchantId, string merchantMCC, Store store)
        {
            this.MerchantName = merchantName;
            this.ReferenceMerchantId = referenceMerchantId;
            this.MerchantMCC = merchantMCC;
            this.Store = store;
        }


        public string ReferenceMerchantId { get; internal set; }


        public string MerchantMCC { get; internal set; }


        public string MerchantName { get; internal set; }


        public Store Store { get; internal set; }
    }
}
