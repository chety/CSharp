using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.ISP
{
    class FoodFactory
    {

        //That is actually is not a good design. What if we want to feed animals. With this design we have add another interface IAnimal
        //Then add another overload method of Feed that takes an IAnimal as parameter. Also there are some common behaviors between animal and
        //human. That will also be duplicate in both interfaces
        public void Feed(IHuman human)
        {
            Console.WriteLine("Provide food to Human");
        }

        //That is not a good design for ISP
        public void Feed(IAnimal animal)
        {
            Console.WriteLine("Provide food to Animal");
        }


        //That is a good design. Whether it is an animal or a human. That is not case for use. The important thing is the species is feedable
        public void FeedGoodWay(IFeedable species)
        {
            Console.WriteLine("Provide food to a feedable species");

        }
    }
}
