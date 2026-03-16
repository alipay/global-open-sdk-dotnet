using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class CreateDirectRefundRequest : AMSRequest<CreateDirectRefundResponse>
    {

        public CreateDirectRefundRequest() { }

        

        public CreateDirectRefundRequest( string paymentId , string refundRequestId , string referenceRefundId , RefundFromMethod refundFromMethod , Amount refundFromAmount , string memo , string remark , string refundReason , string refundNotifyUrl)
        {
            this.PaymentId = paymentId;
            this.RefundRequestId = refundRequestId;
            this.ReferenceRefundId = referenceRefundId;
            this.RefundFromMethod = refundFromMethod;
            this.RefundFromAmount = refundFromAmount;
            this.Memo = memo;
            this.Remark = remark;
            this.RefundReason = refundReason;
            this.RefundNotifyUrl = refundNotifyUrl;
        }

            public string PaymentId { get; set; }
            public string RefundRequestId { get; set; }
            public string ReferenceRefundId { get; set; }
            public RefundFromMethod RefundFromMethod { get; set; }
            public Amount RefundFromAmount { get; set; }
            public string Memo { get; set; }
            public string Remark { get; set; }
            public string RefundReason { get; set; }
            public string RefundNotifyUrl { get; set; }

        public override string GetRequestURI(){ return "/ams/aba/funds/createDirectRefund"; } 


    }

}
