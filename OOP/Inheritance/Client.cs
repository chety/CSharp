using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.OOP.Inheritance
{
    class Client
    {
        private static void Main1(string[] args)
        {
            Square subSquare = new SubSquare();
            var square = new Square();

            Console.WriteLine(subSquare.GetVersionNumber());
            Console.WriteLine(square.GetVersionNumber());
            

            Console.ReadLine();
        }
    }
}
