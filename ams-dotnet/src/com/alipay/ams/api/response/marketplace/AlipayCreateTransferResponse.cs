using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.marketplace
{

public class AlipayCreateTransferResponse : AMSResponse
    {

        public AlipayCreateTransferResponse() { }

        

        public AlipayCreateTransferResponse( Result result , string transferRequestId , string transferId , TransferFromDetailResponse transferFromDetail , TransferToDetailResponse transferToDetail)
        {
            this.Result = result;
            this.TransferRequestId = transferRequestId;
            this.TransferId = transferId;
            this.TransferFromDetail = transferFromDetail;
            this.TransferToDetail = transferToDetail;
        }

            public Result Result { get; set; }
            public string TransferRequestId { get; set; }
            public string TransferId { get; set; }
            public TransferFromDetailResponse TransferFromDetail { get; set; }
            public TransferToDetailResponse TransferToDetail { get; set; }

        

    }

}
