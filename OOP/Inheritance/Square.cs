using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.OOP.Inheritance
{
    public class Square: Shape
    {
        //This is known as method hiding. Instead of Parent method call, use this method.
        public new static string GetDescription()
        {
            return "Square class";
        }

        public string GetClassName()
        {
            return "Square";
        }
    }
}
