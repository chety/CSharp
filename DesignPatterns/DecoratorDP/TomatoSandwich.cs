using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.DecoratorDP
{
    public class TomatoSandwich : SandwichDecorator
    {
        private readonly Sandwich _currentSandwich;

        public TomatoSandwich(Sandwich sandwich)
        {
            _currentSandwich = sandwich;
        }
        public override double Price()
        {
            return _currentSandwich.Price() + 0.5;
        }
        public override string GetDescription()
        {
            return $"{_currentSandwich.GetDescription()} with Tomato";
        }
    }
}
