using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.ISP
{
    class Animal : IAnimal, IFeedable
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Bite()
        {
            throw new NotImplementedException();
        }

        public void Bark()
        {
            throw new NotImplementedException();
        }
    }
}
