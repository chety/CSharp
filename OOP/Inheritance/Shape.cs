using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.OOP.Inheritance
{
    public class Shape : ISquareable, IAreable
    {
        public static string GetDescription()
        {
            return "Shape base class";
        }

        public virtual int GetVersionNumber()
        {
            Console.WriteLine("It is always the base shape class");
            return 1;
        }

        public string ShapeType { get; set; }


        //If there are two same method with same name/signature in two different interfaces and our class implements those :)
        //In C# you can use like below but you can not access these class methods from
        //outside. You can not write public modifier before the method 
        string ISquareable.GetInfo()
        {
            return "ISquareable.GetInfo()";
        }

        string IAreable.GetInfo()
        {
            return "IAreable.GetInfo()";
        }
    }
}
