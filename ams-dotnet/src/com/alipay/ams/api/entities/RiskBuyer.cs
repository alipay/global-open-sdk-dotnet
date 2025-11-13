using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class RiskBuyer
    {

        public RiskBuyer() { }

        

        public RiskBuyer(  string  noteToMerchant ,  string  noteToShipping ,  int?  orderCountIn1H ,  int?  orderCountIn24H)
        {
            this.NoteToMerchant = noteToMerchant;
            this.NoteToShipping = noteToShipping;
            this.OrderCountIn1H = orderCountIn1H;
            this.OrderCountIn24H = orderCountIn24H;
        }

            public  string  NoteToMerchant { get; set; }
            public  string  NoteToShipping { get; set; }
            public  int?  OrderCountIn1H { get; set; }
            public  int?  OrderCountIn24H { get; set; }

        

    }

}
