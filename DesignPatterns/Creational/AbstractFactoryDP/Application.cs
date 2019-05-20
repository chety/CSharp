using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.Creational.AbstractFactoryDP
{
    class Application
    {
        private readonly IButton _button;
        private readonly ICheckBox _checkBox;

        public Application(IButton button, ICheckBox checkBox)
        {
            _button = button;
            _checkBox = checkBox;
        }

        public void Render()
        {
            _button.Render();
            _checkBox.Render();
        }
    }
}
