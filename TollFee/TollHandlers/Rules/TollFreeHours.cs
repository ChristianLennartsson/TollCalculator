using System;
using System.Linq;
using TollFee.Configuration;
using TollFeeCalculator.Vehicles.Types;

namespace TollFee.TollHandlers.Rules
{
    class TollFreeHours : Handler
    {
        public override void Handle(IVehicle vehicle, DateTime date)
        {
            var isTollFreeHours = TollConfiguration.TollHoursStart > date.TimeOfDay && TollConfiguration.TollHoursEnd < date.TimeOfDay;

            if (!isTollFreeHours)
                NextRule(vehicle, date);
        }
    }
}
