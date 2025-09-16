using System.Security.Cryptography.X509Certificates;

namespace WebShop.ProductData
{
    public class Electronics : Product
    {
        public int WarrantyYears;

        public override string ProductInformation()
        {
            return $"The {Name} made by {Brand} costs {Price}";
        }
    
    }
}