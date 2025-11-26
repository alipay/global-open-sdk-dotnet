using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentFactor
    {

        public PaymentFactor() { }

        

        public PaymentFactor( bool? isPaymentEvaluation , InStorePaymentScenario inStorePaymentScenario , PresentmentMode presentmentMode , string captureMode , bool? isAuthorization)
        {
            this.IsPaymentEvaluation = isPaymentEvaluation;
            this.InStorePaymentScenario = inStorePaymentScenario;
            this.PresentmentMode = presentmentMode;
            this.CaptureMode = captureMode;
            this.IsAuthorization = isAuthorization;
        }

            public bool? IsPaymentEvaluation { get; set; }
            public InStorePaymentScenario InStorePaymentScenario { get; set; }
            public PresentmentMode PresentmentMode { get; set; }
            public string CaptureMode { get; set; }
            public bool? IsAuthorization { get; set; }

        

    }

}
