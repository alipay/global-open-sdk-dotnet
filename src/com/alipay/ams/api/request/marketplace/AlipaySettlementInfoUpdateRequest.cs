using com.alipay.ams.api.response.marketplace;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.request.marketplace
{

public class AlipaySettlementInfoUpdateRequest : AMSRequest<AlipaySettlementInfoUpdateResponse>
    {

        public AlipaySettlementInfoUpdateRequest() { }

        public AlipaySettlementInfoUpdateRequest( string updateRequestId , string referenceMerchantId , string settlementCurrency , SettlementBankAccount settlementBankAccount)
        {
            this.UpdateRequestId = updateRequestId;
            this.ReferenceMerchantId = referenceMerchantId;
            this.SettlementCurrency = settlementCurrency;
            this.SettlementBankAccount = settlementBankAccount;
        }

            public string UpdateRequestId { get; set; }
            public string ReferenceMerchantId { get; set; }
            public string SettlementCurrency { get; set; }
            public SettlementBankAccount SettlementBankAccount { get; set; }

        public override string GetRequestURI(){ 
    return "/ams/api/v1/merchants/settlementInfo/update"; 
} 


    }

}
