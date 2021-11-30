using System;
using System.Linq;
using TollFee.Configuration;
using TollFeeCalculator.Vehicles.Types;

namespace TollFee.TollHandlers.Rules
{
    class ReduceOverlappingTollCharges : Handler
    {
        public override void Handle(IVehicle vehicle, DateTime date)
        {
            vehicle.PassingCharges.Aggregate((x, y) => {
                var isWithinMaxDiffMinutes = x.PassingTime.AddMinutes(TollConfiguration.MaximumDiffMinutes) >= y.PassingTime;
                if (isWithinMaxDiffMinutes)
                {
                    var highestCharge = Math.Max(x.TollCharge, y.TollCharge);
                    x.TollCharge = highestCharge;
                    y.TollCharge = 0;
                }
                return y;
            });

            NextRule(vehicle, date);
        }
    }
}
