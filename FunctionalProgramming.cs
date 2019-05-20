using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using  static  System.Console;
namespace Tutor
{
     public  delegate  void WriteMessageDelegate();
    internal class FunctionalProgramming
    {

        private static void Main1(string[] args)
        {
            //writeMessageImperativeWay();
            WriteLine("**************");
            writeMessageFunctionalWay();
            WriteLine("**************");
            Console.ReadLine();
        }

        private static void  writeMessageImperativeWay()
        {
            var messages = new List<WriteMessageDelegate>();
            var numbers = new List<int> { 0, 1, 2, 3, 4 };
            foreach (var number in numbers) // -> it will write "0 1 2 3 4". As we expected. Because in foreach iterable values are immutable
            {
                messages.Add(() => WriteLine($"i = {number}"));
            }

            //for (int i = 0; i < 5; i++)   //->it will write "5 5 5 5 5"
            //{
            //    messages.Add(() => WriteLine(value: $"i = {i}"));
            //}


            messages.ForEach(func => func());
        }

        private static void writeMessageFunctionalWay()
        {
            var numbers = new List<int> {0,1,2,3,4};
            var messages = new List<WriteMessageDelegate>();
            numbers.ForEach(number => messages.Add(()=> WriteLine($"number: {number}")));
            messages.ForEach(func => func());
        }

        private static IEnumerable<string> customMapFunction(IEnumerable<string> values, Predicate<string> predicate)
        {
            return  values.Where(value => predicate(value));
        }

    }
}
