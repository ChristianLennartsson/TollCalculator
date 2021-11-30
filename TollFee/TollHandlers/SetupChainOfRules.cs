using TollFee.TollHandlers.Rules;

namespace TollFee.TollHandlers
{
    public class SetupChainOfRules
    {
        public Handler GetChainOfRules()
        {
            var tollFreePublicHoliday = new TollFreePublicHoliday();
            var tollFreeMonth = new TollFreeMonth();
            var tollFreeDay = new TollFreeDay();
            var tollFreeHours = new TollFreeHours();
            var AddTollCharge = new AddTollCharge();
            var reduceOverlappingTollCharges = new ReduceOverlappingTollCharges();

            tollFreePublicHoliday.SetSuccessor(tollFreeMonth)
                                 .SetSuccessor(tollFreeDay)
                                 .SetSuccessor(tollFreeHours)
                                 .SetSuccessor(AddTollCharge)
                                 .SetSuccessor(reduceOverlappingTollCharges);

            return tollFreePublicHoliday;
        }
    }
}
