using System.Dynamic;

namespace ZooDemo;

class Program
{
    static void Main(string[] args)
    {
        Zoo zoo = new Zoo();

        Animal Simba = new Lion("Simba", 5, 100);
        Animal Zazoo = new Parrot("Zazoo", 2, 40);
        Animal Dumbo = new Elephant("Dumbo", 10, 200);

        zoo.Add(Simba);
        zoo.Add(Zazoo);
        zoo.Add(Dumbo);


        System.Console.WriteLine($"Total Animal Count: {Animal.TotalCount} ");
        zoo.ListAll();
        zoo.AllSpeak();
        zoo.ShowFeedingPlan();
        zoo.ShowTricks();
        zoo.TotalFoodKg();
        zoo.ShowRunSpeed();



    }
}
