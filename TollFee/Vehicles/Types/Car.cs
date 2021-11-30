using System;
using System.Collections.Generic;
using TollFee.Vehicles;

namespace TollFeeCalculator.Vehicles.Types
{
    public class Car : IVehicle
    {
        public Car()
        {
            PassingCharges = new List<VehiclePassing>();
        }

        public bool IsTollable => true;
        public List<VehiclePassing> PassingCharges { get; set; }
    }
}