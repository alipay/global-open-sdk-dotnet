using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.marketplace
{

public class AlipayCreateTransferResponse : AMSResponse
    {

        public AlipayCreateTransferResponse() { }

        

        public AlipayCreateTransferResponse(  Result  result ,  string  transferId ,  string  transferRequestId ,  TransferFromDetail  transferFromDetail ,  TransferToDetail  transferToDetail)
        {
            this.Result = result;
            this.TransferId = transferId;
            this.TransferRequestId = transferRequestId;
            this.TransferFromDetail = transferFromDetail;
            this.TransferToDetail = transferToDetail;
        }

            public  Result  Result { get; set; }
            public  string  TransferId { get; set; }
            public  string  TransferRequestId { get; set; }
            public  TransferFromDetail  TransferFromDetail { get; set; }
            public  TransferToDetail  TransferToDetail { get; set; }

        

    }

}
