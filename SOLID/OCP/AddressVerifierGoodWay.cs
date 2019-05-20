using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.OCP
{
   public class AddressVerifierGoodWay
    {
        public virtual bool IsAddressValid(int zipCode)
        {
            //This is mainly works for USA zipcodes. But if we want to extends to other countries we can create a sub-class and override 
            //this behavior.
            return zipCode > 10;
        }
    }
}
