using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutor.DesignPatterns.FactoryMethodDP;

namespace Tutor.DesignPatterns
{
    class VehicleMaker
    {
        private static void Main1(string[] args)
        {
            var vehicleFactory = new VehicleFactory();
            IVehicle vehicle =  vehicleFactory.CreateVehicle(VehicleType.Truck);
            Console.WriteLine(vehicle.GetVehicleInfo());


            Console.ReadLine();
        }
    }
}
