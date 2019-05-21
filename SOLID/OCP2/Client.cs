using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.OCP2
{
    public class Client
    {
        public static void Main(string[] args)
        {
            var people = new List<IApplicant>
            {
                new ManagerApplicant{FirstName = "Chety", LastName="Clooney"},
                new ExecutiveApplicant{FirstName = "Lionel", LastName="Messi"},
                new Person{FirstName = "Cristiano", LastName="Ronaldo"}
            };

            var employeeList = new List<Employee>();
            people.ForEach(person => employeeList.Add(person.AccountCreator.CreateEmployee(person)));
            employeeList.ForEach(employee => Console.WriteLine(employee));

            Console.ReadLine();
        }
    }
}
