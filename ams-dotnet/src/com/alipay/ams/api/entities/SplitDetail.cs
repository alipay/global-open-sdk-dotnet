using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class SplitDetail
    {

        public SplitDetail() { }

        

        public SplitDetail( string splitTo , Amount splitAmount , Amount actualSplitAmount , string description)
        {
            this.SplitTo = splitTo;
            this.SplitAmount = splitAmount;
            this.ActualSplitAmount = actualSplitAmount;
            this.Description = description;
        }

            public string SplitTo { get; set; }
            public Amount SplitAmount { get; set; }
            public Amount ActualSplitAmount { get; set; }
            public string Description { get; set; }

        

    }

}
