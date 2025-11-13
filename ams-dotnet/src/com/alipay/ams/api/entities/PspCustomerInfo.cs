using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PspCustomerInfo
    {

        public PspCustomerInfo() { }

        

        public PspCustomerInfo(  string  pspName ,  string  pspCustomerId ,  string  displayCustomerId ,  string  displayCustomerName ,  string  customer2088Id ,  string  extendInfo)
        {
            this.PspName = pspName;
            this.PspCustomerId = pspCustomerId;
            this.DisplayCustomerId = displayCustomerId;
            this.DisplayCustomerName = displayCustomerName;
            this.Customer2088Id = customer2088Id;
            this.ExtendInfo = extendInfo;
        }

            public  string  PspName { get; set; }
            public  string  PspCustomerId { get; set; }
            public  string  DisplayCustomerId { get; set; }
            public  string  DisplayCustomerName { get; set; }
            public  string  Customer2088Id { get; set; }
            public  string  ExtendInfo { get; set; }

        

    }

}
