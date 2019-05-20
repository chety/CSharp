using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.FactoryMethodDP
{
    public interface ICreateVehicle
    {
        IVehicle CreateVehicle(VehicleType vehicleType);
    }
}
