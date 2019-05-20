namespace Tutor.SOLID.OCP
{
   public class GermanyAddressVerifierGoodWay : AddressVerifierGoodWay
    {
        public override bool IsAddressValid(int zipCode)
        {
            return zipCode > 5;
        }
    }
}
