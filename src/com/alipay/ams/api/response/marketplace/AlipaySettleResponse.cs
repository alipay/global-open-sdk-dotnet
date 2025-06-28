using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.marketplace
{

public class AlipaySettleResponse : AMSResponse
    {

        public AlipaySettleResponse() { }

        public AlipaySettleResponse( Result result , string settlementRequestId , string settlementId)
        {
            this.Result = result;
            this.SettlementRequestId = settlementRequestId;
            this.SettlementId = settlementId;
        }

            public Result Result { get; set; }
            public string SettlementRequestId { get; set; }
            public string SettlementId { get; set; }

        

    }

}
