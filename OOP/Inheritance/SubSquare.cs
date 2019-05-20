using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.OOP.Inheritance
{
    class SubSquare : Square
    {
        public new string GetClassName()
        {
            return "Sub-Square";
        }

        public override int GetVersionNumber()
        {
            Console.WriteLine("It is Sub-Square class");
            return 2;
        }
    }
}
