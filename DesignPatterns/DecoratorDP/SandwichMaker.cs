using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.DecoratorDP
{
    class SandwichMaker
    {
        private static void Main1(string[] args)
        {
            var sandwich = new WhiteBreadAndCheeseSandwich("White bread and cheese ");
            Console.WriteLine(sandwich.GetDescription());
            Console.WriteLine(sandwich.Price());

            var sandwichWithSausage = new SausageSandwich(sandwich);
            Console.WriteLine(sandwichWithSausage.GetDescription());
            Console.WriteLine(sandwichWithSausage.Price());

            
            Console.ReadLine();
        }
    }
}
