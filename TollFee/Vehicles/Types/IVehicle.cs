using System;
using System.Collections.Generic;
using TollFee.Vehicles;

namespace TollFeeCalculator.Vehicles.Types
{
    public interface IVehicle
    {
        public bool IsTollable { get; }
        public List<VehiclePassing> PassingCharges { get; set; }
    }
}