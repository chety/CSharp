using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.FactoryMethodDP
{
    public class VehicleFactory : ICreateVehicle
    {
        private Dictionary<VehicleType, IVehicle> _vehicleStore;

        public Dictionary<VehicleType, IVehicle> VehicleStore => _vehicleStore ?? (_vehicleStore = new Dictionary<VehicleType, IVehicle>
        {
            {VehicleType.Car, new Car()},
            {VehicleType.Truck, new Truck()},
            {VehicleType.Motorcycle, new Motorcycle()}
        });
        public IVehicle CreateVehicle(VehicleType vehicleType)
        {
            return VehicleStore[vehicleType];
        }
    }
}
