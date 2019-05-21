using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.OCP2
{
    public class Accountant : IAccountCreator
    {
        public Employee CreateEmployee(IApplicant person)
        {
            var employee = new Employee
            {
                FirstName= person.FirstName,
                LastName = person.LastName,
                Email = $"{person.FirstName[0]}{person.LastName}@acme.com"
            };
            return employee;
        }
    }
}
