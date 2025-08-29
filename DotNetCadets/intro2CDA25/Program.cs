namespace intro2CDA25;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your name?");
        string firstName = Console.ReadLine();
        Console.WriteLine($"Hello {firstName}, welcome to the C# world!");


        Console.WriteLine("How old are you?");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Wow, {age} years old! That's great!");

        Console.WriteLine("Do you like pizza?");
        string likePizza = Console.ReadLine();

        if (likePizza.ToLower() == "yes" || likePizza.ToLower() == "y")
        {
            Console.WriteLine("Cool, me too!");
        }
        else
        {
            Console.WriteLine("Weird.");
        }

    }
}
