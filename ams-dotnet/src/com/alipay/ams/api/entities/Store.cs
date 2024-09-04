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


        public string ReferenceStoreId { get;  set; }


        public string StoreName { get;  set; }


        public string StoreMCC { get;  set; }
        
        
        public string StoreDisplayName { get;  set; }
        public string StoreTerminalId { get;  set; }
        public string StoreOperatorId { get;  set; }
        public Address StoreAddress { get;  set; }
        public string StorePhoneNo { get;  set; }
    }
}
