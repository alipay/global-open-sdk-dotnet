using System;


namespace com.alipay.ams.api.entities
{
    public class PaymentFactor
    { 
        public Boolean IsPaymentEvaluation { get; set; }

        public PresentmentMode PresentmentMode { get; set; }

        public String CaptureMode { get; set; }

        public Boolean IsAuthorization { get; set; }


        public InStorePaymentScenario InStorePaymentScenario { get; set; }
    }
}
