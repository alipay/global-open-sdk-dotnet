using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayInquireBatchPaymentResponse : AMSResponse
    {

        public AlipayInquireBatchPaymentResponse() { }

        

        public AlipayInquireBatchPaymentResponse( Result result , string batchPaymentRequestId , Amount paymentAmount , string paymentCreateTime , string paymentMethodType , RedirectActionForm redirectActionForm , PspCustomerInfo pspCustomerInfo , string paymentTime , string authExpirytime , Amount customsDeclarationAmount , List<AmsInquiryPaymentResult> paymentResults)
        {
            this.Result = result;
            this.BatchPaymentRequestId = batchPaymentRequestId;
            this.PaymentAmount = paymentAmount;
            this.PaymentCreateTime = paymentCreateTime;
            this.PaymentMethodType = paymentMethodType;
            this.RedirectActionForm = redirectActionForm;
            this.PspCustomerInfo = pspCustomerInfo;
            this.PaymentTime = paymentTime;
            this.AuthExpirytime = authExpirytime;
            this.CustomsDeclarationAmount = customsDeclarationAmount;
            this.PaymentResults = paymentResults;
        }

            public Result Result { get; set; }
            public string BatchPaymentRequestId { get; set; }
            public Amount PaymentAmount { get; set; }
            public string PaymentCreateTime { get; set; }
            public string PaymentMethodType { get; set; }
            public RedirectActionForm RedirectActionForm { get; set; }
            public PspCustomerInfo PspCustomerInfo { get; set; }
            public string PaymentTime { get; set; }
            public string AuthExpirytime { get; set; }
            public Amount CustomsDeclarationAmount { get; set; }
            public List<AmsInquiryPaymentResult> PaymentResults { get; set; }

        

    }

}
