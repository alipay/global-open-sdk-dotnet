    
namespace com.alipay.ams.api.entities
{

public class SettlementStrategy
    {

        public SettlementStrategy() { }

        public SettlementStrategy( string settlementCurrency)
        {
            this.SettlementCurrency = settlementCurrency;
        }

            public string SettlementCurrency { get; set; }

        

    }

}
