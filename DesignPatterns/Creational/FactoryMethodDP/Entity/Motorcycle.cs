using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.FactoryMethodDP
{
    class Motorcycle : IVehicle
    {
        internal Motorcycle()
        {
            
        }
        public string GetVehicleInfo()
        {
            return "Motorcycle";
        }
    }
}
