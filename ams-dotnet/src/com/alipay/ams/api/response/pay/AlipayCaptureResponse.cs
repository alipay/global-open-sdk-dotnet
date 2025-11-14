using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayCaptureResponse : AMSResponse
    {

        public AlipayCaptureResponse() { }

        

        public AlipayCaptureResponse( Result result , string captureRequestId , string captureId , string paymentId , Amount captureAmount , string captureTime , string acquirerReferenceNo)
        {
            this.Result = result;
            this.CaptureRequestId = captureRequestId;
            this.CaptureId = captureId;
            this.PaymentId = paymentId;
            this.CaptureAmount = captureAmount;
            this.CaptureTime = captureTime;
            this.AcquirerReferenceNo = acquirerReferenceNo;
        }

            public Result Result { get; set; }
            public string CaptureRequestId { get; set; }
            public string CaptureId { get; set; }
            public string PaymentId { get; set; }
            public Amount CaptureAmount { get; set; }
            public string CaptureTime { get; set; }
            public string AcquirerReferenceNo { get; set; }

        

    }

}
