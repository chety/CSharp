using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.FactoryMethodDP
{
    public class Car : IVehicle
    {
        internal Car()
        {
            
        }
        public string GetVehicleInfo()
        {
            return "Car";
        }
    }
}
