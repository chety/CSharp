using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.LSP2
{
    class Client
    {
        private static void Main1(string[] args)
        {
            //var addressService = new AddressService();
            //Address address = addressService.GetAddress(30);

            //var accountService = new AccountService();
            //accountService.SaveAddress(address);

            var newAddressService = new NewAddressService();
            Address newAddress = newAddressService.GetAddress(30);

            var accountService = new AccountService();
            accountService.SaveAddress(newAddress);


        }
    }
}
