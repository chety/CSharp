using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.OCP2
{
    public class Person : IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IAccountCreator AccountCreator { get; set; } = new Accountant();

    }
}
