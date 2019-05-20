using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.LSP2
{
 public    class NewAddressService : AddressService
    {
        //Lets say we have a new address service. Instead of DB we will get addresses from a restfull service anymore. 
        //LSP states that if a method requires a base class then i can send any derived(child) class instead of base class without changing
        //any behavior. 
        public override Address GetAddress(int zipCode)
        {
            //That is my precondition. We change it. It is not a good practice. If a method requires base class and i send this class
            //it will create new behavior
            Require.That(() => zipCode > 15);
            Require.That(() => zipCode < 35);

            //some code. Fetch Address our new shinny brighty mighty RESTFull service.
            var address = new Address
            {
                City = @"Amokachi",
                Country = "Senegal",
                Street = 25,
                ZipCode = 49
            };

            //Also we remove post condition. That is another problem in LSP

            return address;
        }
    }
}
