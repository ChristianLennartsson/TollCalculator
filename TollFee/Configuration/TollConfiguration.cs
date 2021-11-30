using System;
using System.Collections.Generic;

namespace TollFee.Configuration
{
    public static class TollConfiguration
    {
        public static int MaximumTollFee => 60;
        public static int MaximumDiffMinutes => 60;

        public static HashSet<string> TolledHolidays => new HashSet<string> { "Midsommarafton", "Julafton", "Nyårsafton" };
        public static HashSet<DayOfWeek> TollFreeDays => new HashSet<DayOfWeek> { DayOfWeek.Saturday, DayOfWeek.Sunday };
        public static HashSet<int> TollFreeMonts => new HashSet<int> { 7 };

        public static TimeSpan TollHoursStart => new TimeSpan(6, 0, 0);
        public static TimeSpan TollHoursEnd => new TimeSpan(18, 29, 0);

        public static HashSet<TollFeeRule> TollFeeRules => new HashSet<TollFeeRule>
        {
            new TollFeeRule { From = new TimeSpan(6, 0, 0), To = new TimeSpan(6, 29, 0), FeeCharge = 8 },
            new TollFeeRule { From = new TimeSpan(8, 30, 0), To = new TimeSpan(14, 59, 0), FeeCharge = 8 },
            new TollFeeRule { From = new TimeSpan(18, 0, 0), To = new TimeSpan(18, 29, 0), FeeCharge = 8 },

            new TollFeeRule { From = new TimeSpan(6, 30, 0), To = new TimeSpan(6, 59, 0), FeeCharge = 13 },
            new TollFeeRule { From = new TimeSpan(8, 0, 0), To = new TimeSpan(8, 29, 0), FeeCharge = 13 },
            new TollFeeRule { From = new TimeSpan(15, 0, 0), To = new TimeSpan(15, 29, 0), FeeCharge = 13 },
            new TollFeeRule { From = new TimeSpan(17, 0, 0), To = new TimeSpan(17, 59, 0), FeeCharge = 13 },

            new TollFeeRule { From = new TimeSpan(7, 0, 0), To = new TimeSpan(7, 59, 0), FeeCharge = 18 },
            new TollFeeRule { From = new TimeSpan(15, 30, 0), To = new TimeSpan(16, 59, 0), FeeCharge = 18 }
        };
    }
}
