using System;
using Nager.Date;
using System.Collections.Generic;
using System.Linq;
using TollFeeCalculator.Vehicles;
using TollFee.Configuration;
using TollFeeCalculator.Vehicles.Types;
using TollFee.Vehicles;
using TollFee.TollHandlers;

public class TollCalculator
{
    private readonly VehicleFactory _vehicleFactory;
    private readonly Handler _chainOfRules;

    public TollCalculator()
    {
        // TODO Use dependency injection
        _vehicleFactory = new VehicleFactory();
        var setupChainOfRules = new SetupChainOfRules();
        _chainOfRules = setupChainOfRules.GetChainOfRules();
    }

    /**
     * Calculate the total toll fee for one day
     *
     * @param vehicle - the vehicle
     * @param dates   - date and time of all passes on one day
     * @return - the total toll fee for that day
     */
    public int GetTollFee(VehicleTypeEnum vehicleType, DateTime[] dates)
    {
        var vehicle = _vehicleFactory.CreateVehicle(vehicleType);

        if (!vehicle.IsTollable)
            return 0;

        var orderedDates = dates.OrderBy(x => x);
        foreach (var date in orderedDates)
        {
            _chainOfRules.Handle(vehicle, date);
        }

        var totalCharge = vehicle.PassingCharges.Sum(x => x.TollCharge);
        return totalCharge > TollConfiguration.MaximumTollFee ? TollConfiguration.MaximumTollFee : totalCharge;
    }
}

