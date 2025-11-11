    
namespace com.alipay.ams.api.entities
{

public class PeriodRule
    {

        public PeriodRule() { }

        public PeriodRule( string periodType , int? periodCount)
        {
            this.PeriodType = periodType;
            this.PeriodCount = periodCount;
        }

            public string PeriodType { get; set; }
            public int? PeriodCount { get; set; }

        

    }

}
