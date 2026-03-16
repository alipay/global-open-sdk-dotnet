using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquireDirectRefundResponse : AMSResponse
    {

        public AlipayInquireDirectRefundResponse() { }

        

        public AlipayInquireDirectRefundResponse( TransactionStatusType refundStatus , string refundResultMessage , string refundResultCode , string refundId , string paymentId , string refundRequestId , string refundTime , RefundFromMethod refundFromMethod , Amount refundToAmount , Amount refundFromAmount , Result result)
        {
            this.RefundStatus = refundStatus;
            this.RefundResultMessage = refundResultMessage;
            this.RefundResultCode = refundResultCode;
            this.RefundId = refundId;
            this.PaymentId = paymentId;
            this.RefundRequestId = refundRequestId;
            this.RefundTime = refundTime;
            this.RefundFromMethod = refundFromMethod;
            this.RefundToAmount = refundToAmount;
            this.RefundFromAmount = refundFromAmount;
            this.Result = result;
        }

            public TransactionStatusType RefundStatus { get; set; }
            public string RefundResultMessage { get; set; }
            public string RefundResultCode { get; set; }
            public string RefundId { get; set; }
            public string PaymentId { get; set; }
            public string RefundRequestId { get; set; }
            public string RefundTime { get; set; }
            public RefundFromMethod RefundFromMethod { get; set; }
            public Amount RefundToAmount { get; set; }
            public Amount RefundFromAmount { get; set; }
            public Result Result { get; set; }

        

    }

}
