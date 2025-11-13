using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayCaptureRequest : AMSRequest<AlipayCaptureResponse>
    {

        public AlipayCaptureRequest() { }

        

        public AlipayCaptureRequest(  string  captureRequestId ,  string  paymentId ,  Amount  captureAmount ,  bool?  isLastCapture)
        {
            this.CaptureRequestId = captureRequestId;
            this.PaymentId = paymentId;
            this.CaptureAmount = captureAmount;
            this.IsLastCapture = isLastCapture;
        }

            public  string  CaptureRequestId { get; set; }
            public  string  PaymentId { get; set; }
            public  Amount  CaptureAmount { get; set; }
            public  bool?  IsLastCapture { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/capture"; } 


    }

}
