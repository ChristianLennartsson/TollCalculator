using System;
using TollFee.Vehicles;
using TollFeeCalculator.Vehicles;

namespace TollFeeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] date = { new DateTime(2021, 11, 21, 6, 25, 0), new DateTime(2021, 08, 17, 7, 40, 0), new DateTime(2021, 08, 17, 15, 40, 0), new DateTime(2021, 10, 17, 15, 55, 0) };
            TollCalculator toll = new TollCalculator();
            int tollFee = toll.GetTollFee(VehicleTypeEnum.Car, date);
            Console.WriteLine("Today's total toll fee collected is " + tollFee);
        }
    }
}
