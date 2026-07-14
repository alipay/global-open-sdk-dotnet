using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public enum StatementTransactionType
    {
            PAYMENT,
            PAYMENT_REFUND,
            CHARGE,
            CHARGE_REFUND,
            TOPUP,
            SETTLEMENT,
            WITHDRAW,
            WITHDRAW_RETURN,
            TRANSFER,
            TRANSFER_RETURN,
            TRANSFER_TO_CHINA,
            TRANSFER_RECIPIENT,
            EXCHANGE,
            CREDIT_LOAN,
            CREDIT_REPAY,
            CREDIT_REPAYMENT,
            DIRECT_PAYMENT,
            DIRECT_REFUND,
            CARD_PAYMENT,
            CARD_REFUND,
            OVERFLOW_DEBIT,
            OVERFLOW_CREDIT,
            CASH_BACK,
    }
}
