using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.OCP2
{
    public class ManagerAccountant : IAccountCreator
    {
        public Employee CreateEmployee(IApplicant applicant)
        {
            var employee = new Employee
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Email = $"{applicant.FirstName}{applicant.LastName}@acmemgnrs.com",
                IsManager = true
            };            
            return employee;
        }
    }
}
