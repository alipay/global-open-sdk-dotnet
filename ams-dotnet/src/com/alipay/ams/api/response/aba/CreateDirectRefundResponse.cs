using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class CreateDirectRefundResponse : AMSResponse
    {

        public CreateDirectRefundResponse() { }

        

        public CreateDirectRefundResponse( string paymentId , string refundId , string refundRequestId , string refundTime , RefundFromMethod refundFromMethod , Amount refundFromAmount , Amount refundToAmount , Result result)
        {
            this.PaymentId = paymentId;
            this.RefundId = refundId;
            this.RefundRequestId = refundRequestId;
            this.RefundTime = refundTime;
            this.RefundFromMethod = refundFromMethod;
            this.RefundFromAmount = refundFromAmount;
            this.RefundToAmount = refundToAmount;
            this.Result = result;
        }

            public string PaymentId { get; set; }
            public string RefundId { get; set; }
            public string RefundRequestId { get; set; }
            public string RefundTime { get; set; }
            public RefundFromMethod RefundFromMethod { get; set; }
            public Amount RefundFromAmount { get; set; }
            public Amount RefundToAmount { get; set; }
            public Result Result { get; set; }

        

    }

}
