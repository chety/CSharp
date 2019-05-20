﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.Creational.AbstractFactoryDP.Entity
{
    class AppleCheckBox : ICheckBox
    {
        public void Render()
        {
            Console.WriteLine("Apple checkbox rendered");
        }
    }
}
