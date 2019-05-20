using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SOLID.OCP
{
    public class StateFinder
    {
        private Dictionary<int, string> _stateStore;

        public Dictionary<int, string> StateStore =>
            _stateStore ?? (_stateStore = new Dictionary<int, string>()
            {
                {6,"Berlin" },
                {7,"Munich" },
                {11,"California" },
                {12,"Washington" }
            });

        private string getStateByZipCodeFromStore(int zipCode)
        {
            return StateStore.TryGetValue(zipCode, out string state) ? state : $"Unknown zipcode. Zipcode: {zipCode}";
        }

        public string GetStateByZipCode(AddressVerifierGoodWay addressVerifier, int zipCode)
        {
            if (!addressVerifier.IsAddressValid(zipCode))
            {
                throw new ArgumentException("Invalid zipCode", nameof(zipCode));
            }

            return getStateByZipCodeFromStore(zipCode);
        }
    }
}
