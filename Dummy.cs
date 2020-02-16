using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutor.DependencyInjection.Version1.Business;
using Tutor.DependencyInjection.Version2.Business;
using Tutor.DependencyInjection.Version2.Entity;
using Tutor.DependencyInjection.Version2.NinjectImplementation;
using static System.Console;

namespace Tutor
{
    class Dummy
    {
        private int dummyValue;
        private bool isDummy;
        private static void Main(string[] args)
        {
            //Version 1
            var pManager = new ProductManager();
            pManager.SaveProduct();

            Console.WriteLine("**************");

            //Version 2 without ninject
            var pManagerDI = new ProductManagerDI(new LogToText(),new NHibernateDal());
            pManagerDI.SaveProduct();

            Console.WriteLine("**************");

            //Version 3 with ninject. Better implementation. If you want to change log or save
            //methods we just change InstanceMOdule config class
            ILogable log = InstanceFactory.GetInstance<ILogable>();
            ISaveable save = InstanceFactory.GetInstance<ISaveable>();
            var pManagerNinjectDI = new ProductManagerDI(log, save);
            pManagerNinjectDI.SaveProduct();

            Console.ReadLine();
        }
        private int sumOfNumbers(params int[] numbers)
        {
            return numbers.Sum();
        }
        public void writeDefaultValues()
        {
            int methodDummyValue;
            WriteLine($"Class value: {dummyValue}. Is Dummy: {isDummy}");
        }

        private static int SumAll(params int[] numbers)
        {
            var sum = 0;
            return numbers.Sum(n => sum + n);
        }

        private static int SumAll2(int[] numbers)
        {
            var sum = 0;
            return numbers.Sum(n => sum + n);
        }
    }
}

