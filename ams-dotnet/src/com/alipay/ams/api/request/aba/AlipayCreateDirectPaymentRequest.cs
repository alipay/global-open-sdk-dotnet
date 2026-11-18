using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayCreateDirectPaymentRequest : AMSRequest<AlipayCreateDirectPaymentResponse>
    {

        public AlipayCreateDirectPaymentRequest() { }

        

        public AlipayCreateDirectPaymentRequest( string paymentRequestId , string memo , string remark , Order order , string paymentNotifyUrl , PaymentMethod payToMethod , Amount payToAmount , Amount payFromAmount)
        {
            this.PaymentRequestId = paymentRequestId;
            this.Memo = memo;
            this.Remark = remark;
            this.Order = order;
            this.PaymentNotifyUrl = paymentNotifyUrl;
            this.PayToMethod = payToMethod;
            this.PayToAmount = payToAmount;
            this.PayFromAmount = payFromAmount;
        }

            public string PaymentRequestId { get; set; }
            public string Memo { get; set; }
            public string Remark { get; set; }
            public Order Order { get; set; }
            public string PaymentNotifyUrl { get; set; }
            public PaymentMethod PayToMethod { get; set; }
            public Amount PayToAmount { get; set; }
            public Amount PayFromAmount { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/aba/funds/createDirectPayment"; } 


    }

}
