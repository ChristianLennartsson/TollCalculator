using System.Collections.Generic;
using TollFee.Vehicles;

namespace TollFeeCalculator.Vehicles.Types
{
    public class TollFreeVehicle : IVehicle
    {
        public TollFreeVehicle()
        {
            PassingCharges = new List<VehiclePassing>();
        }

        public bool IsTollable => false;
        public List<VehiclePassing> PassingCharges { get; set; }
    }
}
