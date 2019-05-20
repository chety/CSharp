using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.DecoratorDP
{
  public  class SausageSandwich : SandwichDecorator
    {
        private readonly Sandwich _currentSandwich;

        public SausageSandwich(Sandwich sandwich)
        {
            _currentSandwich = sandwich;
        }
        public override double Price()
        {
            return _currentSandwich.Price() + 1;
        }
        public override string GetDescription()
        {
            return $"{_currentSandwich.GetDescription()} with Sausage";
        }
    }
}
