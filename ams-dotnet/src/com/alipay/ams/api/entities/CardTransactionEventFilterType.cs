using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public enum CardTransactionEventFilterType
    {
            AUTH,
            AUTH_CANCEL,
            CAPTURE,
            REFUND,
            CHARGEBACK,
            REPAYMENT,
    }
}
