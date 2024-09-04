using System.Collections.Generic;

namespace com.alipay.ams.api.entities;

public class Transit
{
   public TransitType TransitType { get; set; }
   public List<Leg> Legs { get; set; }
   public List<Passenger> Passengers { get; set; }
}