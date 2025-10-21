namespace WorldSimulator;

class Program
{
    static void Main(string[] args)
    {
        Human adam = new Human("Adam", Gender.Male, "Garden of Eden", true);
        Human eve = new Human("Eve", Gender.Female, "Garden of Eden", true);

        adam.Age = 35;
        eve.Age = 33;

        List<Human> Society = new List<Human>();


        System.Console.WriteLine("The beginning of Humanity...");

        Society.Add(adam);
        Society.Add(eve);
        Society.Add(adam.MakeChild(eve));
        Society.Add(adam.MakeChild(eve));
        Society.Add(adam.MakeChild(eve));
        Society.Add(adam.MakeChild(eve));
        Society.Add(adam.MakeChild(eve));
        Society.Add(adam.MakeChild(eve));
        Society.Add(adam.MakeChild(eve));

        Society[2].GetOlder();
        Society[2].GetOlder();
        Society[2].GetOlder();
        Society[2].GetOlder();
        Society[2].GetOlder();
        Society[2].GetOlder();
        Society[2].GetOlder();
        Society[2].GetOlder();
        Society[2].GetOlder();
        Society[2].GetOlder();

        var peopleOver10 = Society.Where(h => h.Age > 9).ToList();

        foreach (var p in peopleOver10)
        {
            System.Console.WriteLine(p);
        }




    }

}