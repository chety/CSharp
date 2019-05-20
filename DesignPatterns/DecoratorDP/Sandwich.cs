using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.DecoratorDP
{
    public abstract class Sandwich
    {
        protected string Description { get; set; }

        public virtual string GetDescription() => "Sandwich";

        public abstract double Price();

    }
}
