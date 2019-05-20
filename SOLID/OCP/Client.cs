using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.OCP
{
    class Client
    {
        private static void Main1(string[] args)
        {
            var stateFinder = new StateFinder();
            Console.WriteLine(stateFinder.GetStateByZipCode(new AddressVerifierGoodWay(),12));

        }
    }
}
