using Nager.Date;
using System;
using System.Linq;
using TollFee.Configuration;
using TollFeeCalculator.Vehicles.Types;

namespace TollFee.TollHandlers.Rules
{
    public class TollFreePublicHoliday : Handler
    {
        public override void Handle(IVehicle vehicle, DateTime date)
        {
            var tollFreeHolidays = DateSystem.GetPublicHolidays(date.Year, CountryCode.SE)
                                           .Where(x => !TollConfiguration.TolledHolidays.Contains(x.LocalName));

            var isTollFreeHoliday = tollFreeHolidays.Any(x => x.Date == date.Date || x.Date.AddDays(-1) == date.Date);

            if (!isTollFreeHoliday)
                NextRule(vehicle, date);
        }
    }
}
