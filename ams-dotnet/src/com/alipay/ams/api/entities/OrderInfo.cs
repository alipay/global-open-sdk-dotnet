using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class OrderInfo
    {

        public OrderInfo() { }

        

        public OrderInfo( Amount orderAmount)
        {
            this.OrderAmount = orderAmount;
        }

            public Amount OrderAmount { get; set; }

        

    }

}
