using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.DecoratorDP
{
    public abstract class SandwichDecorator : Sandwich
    {
        public abstract override double Price();
    }
}
