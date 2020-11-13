using System;


namespace com.alipay.ams.api.entities
{
    public class Store
    {

        public Store(string storeName, string referenceStoreId, string storeMCC)
        {
            this.ReferenceStoreId = referenceStoreId;
            this.StoreName = storeName;
            this.StoreMCC = storeMCC;
        }


        public string ReferenceStoreId { get; internal set; }


        public string StoreName { get; internal set; }


        public string StoreMCC { get; internal set; }
    }
}
