using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.LSP2
{
   public class AccountService
    {
        public void SaveAddress(Address address)
        {
            //That was AddressService.GetAddress() post-condition. And it is now my SaveAddress pre-condition
            Require.That(() => address.ZipCode > 1000);
            Console.WriteLine(@"Address has been successfully added.");
        }
    }
}
