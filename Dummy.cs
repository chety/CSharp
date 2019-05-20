using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Tutor
{

    internal class MyProduct
    {
        public int Id;
        public string FullName { get; set; }

        public MyProduct()
        {
            Id = -33;
        }
        public MyProduct(int id,string fullName)
        {
            Id = id;
            FullName = fullName;
        }

        public override string ToString()
        {
            return $"Id: {Id} FullName: {FullName}";
        }
    }
    class Dummy
    {
        private static void Main3(string[] args)
        {
            WriteLine(SumAll(1, 2, 3, 4));
            WriteLine(SumAll2(new int[] { 1, 2, 3, 4 }));

            var product = new MyProduct();
            product.Id = 53;
            product.FullName = "Super Product";
            WriteLine(product.FullName);


            switch (product.FullName)
            {
                case "Super Product" when product.Id == 33:
                    WriteLine("Actual Super Product");
                    break;
                case "Super Product" when product.Id != 33:
                    WriteLine("Fake Product");
                    break;
                default:
                    WriteLine("Unknown product");
                    break;
            }

            Console.ReadLine();
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
