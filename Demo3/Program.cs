namespace Demo3;

class Program
{
    static void Main(string[] args)
    {

        List<string> list = new List<string>() { "Potato", "Tomato", "Carrot", "Eggplant" };

        System.Console.WriteLine("Choose a product: ");

        for (int i = 0; i < list.Count; i++)
        {
            System.Console.WriteLine($"{i + 1}. {list[i]}");
        }
        
        try
        {

        int choice = int.Parse(Console.ReadLine());
        System.Console.WriteLine($"You have chosen: {list[choice - 1]}");

        }
        catch (Exception e)
        {
        
            System.Console.WriteLine(e.Message);
        }
      

        Console.ReadKey();
    }

}
