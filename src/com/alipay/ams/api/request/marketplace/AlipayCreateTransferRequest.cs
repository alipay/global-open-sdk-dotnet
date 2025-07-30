using com.alipay.ams.api.response.marketplace;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.request.marketplace
{

public class AlipayCreateTransferRequest : AMSRequest<AlipayCreateTransferResponse>
    {

        public AlipayCreateTransferRequest() { }

        public AlipayCreateTransferRequest( string transferRequestId , TransferFromDetail transferFromDetail , TransferToDetail transferToDetail)
        {
            this.TransferRequestId = transferRequestId;
            this.TransferFromDetail = transferFromDetail;
            this.TransferToDetail = transferToDetail;
        }

            public string TransferRequestId { get; set; }
            public TransferFromDetail TransferFromDetail { get; set; }
            public TransferToDetail TransferToDetail { get; set; }

        public override string GetRequestURI(){ 
    return "/ams/api/v1/funds/createTransfer"; 
} 


    }

}
