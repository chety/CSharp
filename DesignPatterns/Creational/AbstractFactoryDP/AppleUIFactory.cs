using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutor.DesignPatterns.Creational.AbstractFactoryDP.Entity;


namespace Tutor.DesignPatterns.Creational.AbstractFactoryDP
{
    public class AppleUIFactory : IGUICreatorFactory
    {
        public IButton CreateButton()
        {
            return new AppleButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new AppleCheckBox();
        }
    }
}
