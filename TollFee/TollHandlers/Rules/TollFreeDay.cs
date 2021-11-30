using System;
using System.Linq;
using TollFee.Configuration;
using TollFeeCalculator.Vehicles.Types;

namespace TollFee.TollHandlers.Rules
{
    class TollFreeDay : Handler
    {
        public override void Handle(IVehicle vehicle, DateTime date)
        {
            var isTollFreeDay = TollConfiguration.TollFreeDays.Any(x => x == date.DayOfWeek);

            if (!isTollFreeDay)
                NextRule(vehicle, date);
        }
    }
}
