using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayRefundRequest : AMSRequest<AlipayRefundResponse>
    {

        public AlipayRefundRequest() { }

        

        public AlipayRefundRequest( string metadata , CustomizedInfo customizedInfo , string captureId , RefundToBankInfo refundToBankInfo , string refundRequestId , string paymentId , string referenceRefundId , Amount refundAmount , string refundReason , string refundNotifyUrl , bool? isAsyncRefund , string extendInfo , List<RefundDetail> refundDetails , string refundSourceAccountNo , Amount actualRefundAmount)
        {
            this.Metadata = metadata;
            this.CustomizedInfo = customizedInfo;
            this.CaptureId = captureId;
            this.RefundToBankInfo = refundToBankInfo;
            this.RefundRequestId = refundRequestId;
            this.PaymentId = paymentId;
            this.ReferenceRefundId = referenceRefundId;
            this.RefundAmount = refundAmount;
            this.RefundReason = refundReason;
            this.RefundNotifyUrl = refundNotifyUrl;
            this.IsAsyncRefund = isAsyncRefund;
            this.ExtendInfo = extendInfo;
            this.RefundDetails = refundDetails;
            this.RefundSourceAccountNo = refundSourceAccountNo;
            this.ActualRefundAmount = actualRefundAmount;
        }

            public string Metadata { get; set; }
            public CustomizedInfo CustomizedInfo { get; set; }
            public string CaptureId { get; set; }
            public RefundToBankInfo RefundToBankInfo { get; set; }
            public string RefundRequestId { get; set; }
            public string PaymentId { get; set; }
            public string ReferenceRefundId { get; set; }
            public Amount RefundAmount { get; set; }
            public string RefundReason { get; set; }
            public string RefundNotifyUrl { get; set; }
            public bool? IsAsyncRefund { get; set; }
            public string ExtendInfo { get; set; }
            public List<RefundDetail> RefundDetails { get; set; }
            public string RefundSourceAccountNo { get; set; }
            public Amount ActualRefundAmount { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/refund"; } 


    }

}
