using System;
using TollFeeCalculator.Vehicles.Types;

namespace TollFee.TollHandlers
{
    public abstract class Handler
    {
        protected Handler _successor;
        public Handler SetSuccessor(Handler successor)
        {
            _successor = successor;
            return _successor;
        }

        public abstract void Handle(IVehicle vehicle, DateTime date);

        public void NextRule(IVehicle vehicle, DateTime date)
        {
            if (_successor != null)
                _successor.Handle(vehicle, date);
        }
    }
}
