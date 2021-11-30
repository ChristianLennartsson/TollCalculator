using System;

namespace TollFee.Helpers
{
    public static class TimeSpanExtensions
    {
        public static bool IsBetween(this TimeSpan date, TimeSpan start, TimeSpan end)
        {
            return start <= date && end >= date;
        }
    }
}
