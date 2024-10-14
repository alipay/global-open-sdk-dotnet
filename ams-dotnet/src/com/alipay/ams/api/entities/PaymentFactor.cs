using System;


namespace com.alipay.ams.api.entities
{
    public class PaymentFactor
    { 
        public bool? IsPaymentEvaluation { get; set; }

        public PresentmentMode PresentmentMode { get; set; }

        public String CaptureMode { get; set; }

        public bool? IsAuthorization { get; set; }


        public InStorePaymentScenario InStorePaymentScenario { get; set; }
    }
}
