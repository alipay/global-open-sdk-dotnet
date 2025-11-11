using com.alipay.ams.api.response.marketplace;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.request.marketplace
{

public class AlipayInquireBalanceRequest : AMSRequest<AlipayInquireBalanceResponse>
    {

        public AlipayInquireBalanceRequest() { }

        public AlipayInquireBalanceRequest( string referenceMerchantId)
        {
            this.ReferenceMerchantId = referenceMerchantId;
        }

            public string ReferenceMerchantId { get; set; }

        public override string GetRequestURI(){ 
    return "/ams/api/v1/accounts/inquireBalance"; 
} 


    }

}
