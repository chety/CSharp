using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.OCP2
{
    public interface IApplicant
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccountCreator AccountCreator { get; set; }
    }
}
