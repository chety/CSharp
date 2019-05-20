using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.FactoryMethodDP
{
    class Truck: IVehicle
    {
        internal Truck()
        {
            
        }
        public string GetVehicleInfo()
        {
            return "Truck";
        }
    }
}
