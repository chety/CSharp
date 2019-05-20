using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.Creational.AbstractFactoryDP
{
    class Client
    {
        private static void Main1(string[] args)
        {
            IGUICreatorFactory factory = UiGenerator.GenerateUIGenerator();
            IButton button = factory.CreateButton();
            ICheckBox checkBox = factory.CreateCheckBox();

            var app = new Application(button, checkBox);
            app.Render();

            Console.ReadLine();
        }
    }
}
