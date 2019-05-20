using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.OCP
{
    public class AddressVerifier
    {
        public static bool IsAddressValid(int zipCode)
        {
            //Lets say we expand our business , and support germany as well. And for Germany zipcode > 5 is valid.
            //If we change business here it will produce some unexpected behaviours. For example when we pass 6 for State finder
            //we get invalid zipcode exception before. But now it will return Berlin or whatever instead. That change our existing class
            //behavior. Classes should be open to extension but close to modification. (Open / Closed Principle)
            return zipCode > 5;
            //return zipCode > 10;
        }
    }
}
