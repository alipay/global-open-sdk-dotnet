using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquireDirectRefundRequest : AMSRequest<AlipayInquireDirectRefundResponse>
    {

        public AlipayInquireDirectRefundRequest() { }

        

        public AlipayInquireDirectRefundRequest( string refundId , string refundRequestId)
        {
            this.RefundId = refundId;
            this.RefundRequestId = refundRequestId;
        }

            public string RefundId { get; set; }
            public string RefundRequestId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/aba/funds/inquireDirectRefund"; } 


    }

}
