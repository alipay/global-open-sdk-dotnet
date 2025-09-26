    
namespace com.alipay.ams.api.entities
{

public class RiskOrder
    {

        public RiskOrder() { }

        public RiskOrder( string orderType , string referringSite)
        {
            this.OrderType = orderType;
            this.ReferringSite = referringSite;
        }

            public string OrderType { get; set; }
            public string ReferringSite { get; set; }

        

    }

}
