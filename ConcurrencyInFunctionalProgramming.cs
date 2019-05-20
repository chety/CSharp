using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using static System.Linq.Enumerable;

namespace Tutor
{
    internal class ConcurrencyInFunctionalProgramming
    {
        public static void Main2(string[] args)
        {
            var numbers = Range(-10000, 20001).Reverse().ToList();
            void task1() => WriteLine(numbers.Sum());
            void task2()
            {
                numbers.Sort(); //sort mutate the original list. Not good practice for FP
                WriteLine(numbers.Sum());
            }

            //Actually it is not good to parallelism when you mutate data. For example in task2 Sort is mutating the list. We can get wrong result 
            Parallel.Invoke(task1, task2);
            ReadLine();
        }
    }
}
