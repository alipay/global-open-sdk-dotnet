    
namespace com.alipay.ams.api.entities
{

public class Store
    {

        public Store() { }

        public Store( string referenceStoreId , string storeName , string storeMCC , string storeDisplayName , string storeTerminalId , string storeOperatorId , Address storeAddress , string storePhoneNo)
        {
            this.ReferenceStoreId = referenceStoreId;
            this.StoreName = storeName;
            this.StoreMCC = storeMCC;
            this.StoreDisplayName = storeDisplayName;
            this.StoreTerminalId = storeTerminalId;
            this.StoreOperatorId = storeOperatorId;
            this.StoreAddress = storeAddress;
            this.StorePhoneNo = storePhoneNo;
        }

            public string ReferenceStoreId { get; set; }
            public string StoreName { get; set; }
            public string StoreMCC { get; set; }
            public string StoreDisplayName { get; set; }
            public string StoreTerminalId { get; set; }
            public string StoreOperatorId { get; set; }
            public Address StoreAddress { get; set; }
            public string StorePhoneNo { get; set; }

        

    }

}
