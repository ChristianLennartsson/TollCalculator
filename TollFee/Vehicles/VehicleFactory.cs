using TollFeeCalculator.Vehicles.Types;

namespace TollFee.Vehicles
{
    public class VehicleFactory
    {
        public IVehicle CreateVehicle(VehicleTypeEnum vehicle)
        {
            switch (vehicle)
            {
                case VehicleTypeEnum.Default:
                    return new TollFreeVehicle();
                case VehicleTypeEnum.Motorbike:
                    return new TollFreeVehicle();
                case VehicleTypeEnum.Tractor:
                    return new TollFreeVehicle();
                case VehicleTypeEnum.Emergency:
                    return new TollFreeVehicle();
                case VehicleTypeEnum.Diplomat:
                    return new TollFreeVehicle();
                case VehicleTypeEnum.Foreign:
                    return new TollFreeVehicle();
                case VehicleTypeEnum.Military:
                    return new TollFreeVehicle();
                case VehicleTypeEnum.Car:
                    return new Car();
                default:
                    return new TollFreeVehicle();
            }
        }
    }
}
