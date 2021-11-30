using System;

namespace TollFee.Configuration
{
    public class TollFeeRule
    {
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
        public int FeeCharge { get; set; }
    }
}
