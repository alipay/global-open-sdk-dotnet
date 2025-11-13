using com.alipay.ams.api.response.marketplace;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.marketplace
{

public class AlipaySettleRequest : AMSRequest<AlipaySettleResponse>
    {

        public AlipaySettleRequest() { }

        

        public AlipaySettleRequest(  string  settlementRequestId ,  string  paymentId ,  List<SettlementDetail>  settlementDetails)
        {
            this.SettlementRequestId = settlementRequestId;
            this.PaymentId = paymentId;
            this.SettlementDetails = settlementDetails;
        }

            public  string  SettlementRequestId { get; set; }
            public  string  PaymentId { get; set; }
            public  List<SettlementDetail>  SettlementDetails { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/settle"; } 


    }

}
