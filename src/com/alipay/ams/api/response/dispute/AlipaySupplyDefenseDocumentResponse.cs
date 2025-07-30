using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.dispute
{

public class AlipaySupplyDefenseDocumentResponse : AMSResponse
    {

        public AlipaySupplyDefenseDocumentResponse() { }

        public AlipaySupplyDefenseDocumentResponse( Result result , string disputeId , string disputeResolutionTime)
        {
            this.Result = result;
            this.DisputeId = disputeId;
            this.DisputeResolutionTime = disputeResolutionTime;
        }

            public Result Result { get; set; }
            public string DisputeId { get; set; }
            public string DisputeResolutionTime { get; set; }

        

    }

}
