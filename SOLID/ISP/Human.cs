using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.ISP
{
    class Human : IHuman , IFeedable
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Talk()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Drink()
        {
            throw new NotImplementedException();
        }
    }
}
