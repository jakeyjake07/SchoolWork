using WebShop.ProductData;

namespace WebShop;

class Program
{
    static void Main(string[] args)
    {
        List<Product> inventory = new List<Product>()
        {
            new Book { Name = "Potato", Brand = "Potati Corp.", Price = 199.95, Author = "Bjarne Stroustrup" },
            new Electronics { Name = "Mouse", Brand = "Logitech", Price = 99.99, WarrantyYears = 3 },
            new Clothing { Name = "T-Shirt", Brand = "H&M", Price = 49.99, Size = "L" },
        };



        bool running = true;
        while (running)
        {
            System.Console.WriteLine("--- Web Shop (Admin Menu) ---");
            System.Console.WriteLine("1. Add Product");
            System.Console.WriteLine("2. List Products");
            System.Console.WriteLine("3. Show Inventory");
            System.Console.WriteLine("4. Total Inventory Value");
            System.Console.WriteLine("5. Set Global Discount");
            System.Console.WriteLine("6. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct(inventory);
                    break;

                case 2:
                    ListProducts(inventory);
                    break;

                case 3:
                    System.Console.WriteLine(Product.TotalCount);
                    break;

                case 4:
                    //TotalInventoryValue(inventory);
                    System.Console.WriteLine("Total Inventory Value: " + CalculateTotalValue(inventory));

                    break;

                case 5:
                    ChangeGlobalDiscount();
                    System.Console.WriteLine("Global Discount is added to all products.");
                    break;

                case 6:
                    running = false;
                    break;

                default:
                    System.Console.WriteLine("Invalid choice");
                    break;
            }


        }

    }

    static void AddProduct(List<Product> inventory)
    {
        System.Console.WriteLine("--- Add Product ---");
        System.Console.WriteLine("1. Book");
        System.Console.WriteLine("2. Electronics");
        System.Console.WriteLine("3. Clothing");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                //Add book
                Book b = new Book();
                FillCommonFields(b);
                System.Console.Write("Enter Author: ");
                b.Author = Console.ReadLine();
                inventory.Add(b);

                break;

            case 2:
                //Add electronics
                Electronics e = new Electronics();
                FillCommonFields(e);
                System.Console.Write("Warranty (years): ");
                e.WarrantyYears = int.Parse(Console.ReadLine());
                inventory.Add(e);

                break;

            case 3:
                //Add clothing
                Clothing c = new Clothing();
                FillCommonFields(c);
                System.Console.Write("Enter Size: ");
                c.Size = System.Console.ReadLine();
                inventory.Add(c);

                break;

            default:
                System.Console.WriteLine("Invalid choice");

                break;
        }
    }

    static void FillCommonFields(Product p)
    {
        System.Console.Write("Enter Prodcut Name: ");
        p.Name = Console.ReadLine();
        System.Console.Write("Enter Brand Name: ");
        p.Brand = Console.ReadLine();
        System.Console.Write("Enter Price: ");
        p.Price = double.Parse(Console.ReadLine());

    }

    static void ListProducts(List<Product> products)
    {
        foreach (Product p in products)
        {
            System.Console.WriteLine(p.ProductDetails());
        }
    }

    static double CalculateTotalValue(List<Product> products)
    {
        double total = 0;
        foreach (Product p in products)
        {
            total += p.Price;
        }
        return total;
    }


    static void ChangeGlobalDiscount()
    {
        System.Console.WriteLine("Enter Global Discount in % : ");
        double percent = double.Parse(Console.ReadLine());
        Product.SetGlobalDiscount(percent);
    }

}





