using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class SettlementDetail
    {

        public SettlementDetail() { }

        

        public SettlementDetail( SettleToType settleTo , Amount settlementAmount)
        {
            this.SettleTo = settleTo;
            this.SettlementAmount = settlementAmount;
        }

            public SettleToType SettleTo { get; set; }
            public Amount SettlementAmount { get; set; }

        

    }

}
