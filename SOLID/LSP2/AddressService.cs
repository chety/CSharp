using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.LSP2
{
    public class AddressService
    {
        /// <summary>
        /// Gets Address of specified zipCode from database.
        /// </summary>
        /// <param name="zipCode"></param>
        /// <returns></returns>
        public virtual Address GetAddress(int zipCode)
        {
            //That is my precondition
            Require.That(() => zipCode > 25);

            //some code. Fetch Address from db
            var address = new Address
            {
                City = @"Mulhalm",
                Country = "United Kingdom",
                Street = 216,
                ZipCode = 3100
            };

            //That is my post condition
            Require.That(() => address.ZipCode > 1000);
            return address;
        }
    }
}
