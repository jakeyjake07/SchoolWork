namespace WebShop.ProductData
{
    public class Clothing : Product
    {
        public string Size;

        public override string ProductInformation()
        {
            return $"The clothing article {Name} made by {Brand} costs {Price}";
        }
    }
}