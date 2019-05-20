using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Tutor
{
    internal class ImperativeDeclarativeAndFunctionalStyle
    {
        private static void Main1(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, -99, -12 };
            WriteLine(FindMinimumImperative(numbers));
            WriteLine(FindMinimumDeclarative(numbers));
            WriteLine(FindMinimumAmongEvenFunctional(numbers));
            ReadLine();
        }

        /// <summary>
        /// Imperative style is about "how" not "what". It is difficult to keep track of, read and understand as opposed to declarative style
        /// There are a lot of garbage values(i,length,min) and mutation process.(In every loop we mutate min and i variable. noisy,verbose ...etc)
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        private static int FindMinimumImperative(IReadOnlyList<int> numbers)
        {
            var min = numbers[0];
            for (int i = 1, length = numbers.Count; i < length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        /// <summary>
        /// Declarative style is about "what" not "how".  More expressive, easy to read/understand by other developers
        /// The declarative style is concise, expressive, uses no garbage variables, and has no explicit mutation.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int FindMinimumDeclarative(IReadOnlyList<int> numbers)
        {
            var result = numbers.OrderBy(a => a);
            return result.First();
        }

        /// <summary>
        /// Functional style has all the benefits of declarative style plus we can use function decomposition as a design tool.
        /// All Functional styles are Declarative but the opposite is not true.
        /// Functional Style = Declarative Style + Higher Order Functions
        /// Higher order functions are functions which take as an argument/Create/return a function. For example in below code we delegate the even number find
        /// process to Where hoc. Where Higher Order Function takes a predicate and returns a boolean value
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int FindMinimumAmongEvenFunctional(IReadOnlyList<int> numbers)
        {
            return numbers.Where(num => num % 2 == 0).OrderBy(num => num).FirstOrDefault();
        }
    }
}
