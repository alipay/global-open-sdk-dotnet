using System;
using System.Collections.Generic;
using System.Text.Json;

using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public class PaymentCancelRequest : AMSRequest<PaymentCancelResponse>
    {

        public string PaymentId { get; set; }
        public string PaymentRequestId { get; set; }
        
        public string MerchantAccountId { get; set; }

        public override string GetRequestURI()
        {
            return AntomPathConstants.CANCEL_PATH;
        }

        public override void validate()
        {
           
        }
    }
}
