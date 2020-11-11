
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace com.alipay.ams.api.request
{
    public class PaymentCreateResponse : AMSResponse
    {


        public string PaymentRequestId { get; set; }


        public string PaymentId { get; set; }


        public Amount PaymentAmount { get; set; }


        public string ClientPaymentToken { get; set; }


        public RedirectActionForm RedirectActionForm { get; set; }


    }
}