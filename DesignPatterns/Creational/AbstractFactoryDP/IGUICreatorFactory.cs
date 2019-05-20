using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.Creational.AbstractFactoryDP
{
    public  interface IGUICreatorFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }
}
