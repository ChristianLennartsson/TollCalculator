using System;
using System.Collections.Generic;
using System.Linq;
using TollFee.Configuration;
using TollFee.Helpers;
using TollFee.Vehicles;
using TollFeeCalculator.Vehicles.Types;

namespace TollFee.TollHandlers.Rules
{
    class AddTollCharge : Handler
    {
        public override void Handle(IVehicle vehicle, DateTime date)
        {
            var rule = TollConfiguration.TollFeeRules.FirstOrDefault(x => date.TimeOfDay.IsBetween(x.From, x.To));
            var charge = rule?.FeeCharge ?? 0;

            if (vehicle.PassingCharges == null)
                vehicle.PassingCharges = new List<VehiclePassing>();

            vehicle.PassingCharges.Add(new VehiclePassing { PassingTime = date, TollCharge = charge });

            NextRule(vehicle, date);
        }
    }
}
