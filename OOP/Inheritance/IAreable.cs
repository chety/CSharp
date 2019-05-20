using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.OOP.Inheritance
{
    public interface IAreable
    {
        string ShapeType { get; set; }
        string GetInfo();
    }
}
