namespace SQLDemo3;

class Program
{
    static void Main(string[] args)
    {
        var dbService = new ProductService();

        //Add product
        /* Product p = new Product();
        p.Name = "Jetski";
        p.Price = 99.99m;
        dbService.AddProduct(p); */


        //Write all products

        /* System.Console.WriteLine("All products in the database: ");

        var products = dbService.GetProducts(); 

        foreach (var p in products)
        {
            System.Console.WriteLine($"{p.Id}. {p.Name} - {p.Price}");
        } */

        //Write one specific product
        /* 
                System.Console.WriteLine("Reading one product");
                var p = dbService.GetProduct(4);
                System.Console.WriteLine(p.Name); */

    }
}
