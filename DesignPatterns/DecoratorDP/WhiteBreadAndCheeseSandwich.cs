using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.DecoratorDP
{
    public   class WhiteBreadAndCheeseSandwich : Sandwich
    {
        public WhiteBreadAndCheeseSandwich(string description)
        {
            Description = description;
        }
        public override string GetDescription()
        {
            return $"{base.GetDescription()} {Description}"; 
        }
        public override double Price()
        {
            return 5;
        }
    }
}
