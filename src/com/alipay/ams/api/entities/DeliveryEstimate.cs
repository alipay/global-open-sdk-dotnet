    
namespace com.alipay.ams.api.entities
{

public class DeliveryEstimate
    {

        public DeliveryEstimate() { }

        public DeliveryEstimate( DeliveryEstimateInfo minimum , DeliveryEstimateInfo maximum)
        {
            this.Minimum = minimum;
            this.Maximum = maximum;
        }

            public DeliveryEstimateInfo Minimum { get; set; }
            public DeliveryEstimateInfo Maximum { get; set; }

        

    }

}
