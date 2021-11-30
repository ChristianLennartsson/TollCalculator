using System;
using System.Linq;
using TollFee.Configuration;
using TollFeeCalculator.Vehicles.Types;

namespace TollFee.TollHandlers.Rules
{
    class TollFreeMonth : Handler
    {
        public override void Handle(IVehicle vehicle, DateTime date)
        {
            var isTollFreeMonth = TollConfiguration.TollFreeMonts.Any(x => x == date.Month);

            if (!isTollFreeMonth)
                NextRule(vehicle, date);
        }
    }
}
