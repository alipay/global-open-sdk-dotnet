using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ExternalPaymentMethodDetail
    {

        public ExternalPaymentMethodDetail() { }

        

        public ExternalPaymentMethodDetail( string assetToken , string accountDisplayName , string disableReason , string paymentMethodDetailMetadata)
        {
            this.AssetToken = assetToken;
            this.AccountDisplayName = accountDisplayName;
            this.DisableReason = disableReason;
            this.PaymentMethodDetailMetadata = paymentMethodDetailMetadata;
        }

            public string AssetToken { get; set; }
            public string AccountDisplayName { get; set; }
            public string DisableReason { get; set; }
            public string PaymentMethodDetailMetadata { get; set; }

        

    }

}
