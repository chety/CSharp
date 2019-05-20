using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutor.DesignPatterns.Creational.AbstractFactoryDP.Entity;

namespace Tutor.DesignPatterns.Creational.AbstractFactoryDP
{
    public class WindowsUIFactory : IGUICreatorFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WindowsCheckBox();
        }
    }
}
