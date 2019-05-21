using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.OCP2
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public bool IsManager { get; set; }
        public bool IsExecutive { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} LastName:{LastName} Email: {Email} IsManager:{IsManager} IsExecutive:{IsExecutive}";
        }
    }
}
