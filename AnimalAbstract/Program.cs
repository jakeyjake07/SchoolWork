namespace AnimalAbstract;

class Program
{
    static void Main(string[] args)
    {
        Dogs dog = new Dogs();
        Cats cat = new Cats();

        System.Console.WriteLine("--- Dogs ---");
        dog.MakeSound();
        dog.Sleep();
        dog.Eat();

        System.Console.WriteLine("--- Cats ---");
        cat.MakeSound();
        cat.Sleep();
        cat.Eat();
    }
}
