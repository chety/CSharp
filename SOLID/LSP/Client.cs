using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.LSP
{
    class Client
    {
        private static double calculateArea(Rectangle rectangle)
        {
            //Even we say square is a special kind of Rectangle. but that violates the liskov principle. If a method require a base class
            //instance we can send child class also without breaking any execution
            //Function that use the base class reference can also use child class instances without knowing it
            rectangle.SetHeight(5); 
            rectangle.SetWidth(8);
            return rectangle.Area();
        }
        private static void Main1(string[] args)
        {
            var rect = new Rectangle();
            var square = new Square();

            Console.WriteLine(calculateArea(rect));
            Console.WriteLine(calculateArea(square));

            Console.ReadLine();
        }
    }
}
