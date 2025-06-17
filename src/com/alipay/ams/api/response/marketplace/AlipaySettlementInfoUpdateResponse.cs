using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.marketplace
{

public class AlipaySettlementInfoUpdateResponse : AMSResponse
    {

        public AlipaySettlementInfoUpdateResponse() { }

        public AlipaySettlementInfoUpdateResponse( Result result , string updateStatus)
        {
            this.Result = result;
            this.UpdateStatus = updateStatus;
        }

            public Result Result { get; set; }
            public string UpdateStatus { get; set; }

        

    }

}
