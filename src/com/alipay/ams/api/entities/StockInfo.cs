    
namespace com.alipay.ams.api.entities
{

public class StockInfo
    {

        public StockInfo() { }

        public StockInfo( string listedRegion , string tickerSymbol)
        {
            this.ListedRegion = listedRegion;
            this.TickerSymbol = tickerSymbol;
        }

            public string ListedRegion { get; set; }
            public string TickerSymbol { get; set; }

        

    }

}
