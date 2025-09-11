namespace SuperHeroes;


public class SuperHero
{
    public string Name = "Unknown Name";
    public int PowerLevel = 1;

    public SuperHero(string name, int powerLevel)
    {
        Name = name;
        PowerLevel = powerLevel;
        /* Introduce(); */
    }

    public void Introduce()
    {
        System.Console.WriteLine($"My name is {Name}, power level: {PowerLevel}");

    }

    public void Taunt(Villain villain)
    {
        System.Console.WriteLine($"{Name} taunts {villain.Name}");

    }



    public void Fight(Villain villain)
    {
        System.Console.WriteLine($"{Name} fights {villain.Name}");
        if (PowerLevel >= villain.EvilLevel)
        {
            System.Console.WriteLine($"{Name} wins!");
        }
        else
        {
            System.Console.WriteLine($"{villain.Name} wins!");
        }
    }



    public void Train(int amount)
    {
        PowerLevel += amount;
        System.Console.WriteLine($"{Name} trains, gained {amount}. Total power level: {PowerLevel}");
    }

}

public class Villain
{
    public string Name = "Unknown Name";
    public int EvilLevel = 1;

    public Villain(string name, int evilLevel)
    {
        Name = name;
        EvilLevel = evilLevel;
        Introduce();
    }


    public void Introduce()
    {
        System.Console.WriteLine($"My name is {Name}, evil level: {EvilLevel}");
    }

}


class Program
{
    static void Main(string[] args)
    {

        /* SuperHero hero1 = new SuperHero("SuperMan", 1000);
        SuperHero hero2 = new SuperHero("Batman", 500);
        SuperHero hero3 = new SuperHero("Captain America", 5);


        Villain villain1 = new Villain("Thanos", 100000);
        Villain villain2 = new Villain("Joker", 100); */

        /*  hero1.Train(100000);
         hero1.Taunt(villain1);
         hero1.Fight(villain1);
  */
        List<SuperHero> heroes = new List<SuperHero>
        {
            new SuperHero("SuperMan", 1000),
            new SuperHero("Batman", 500),
            new SuperHero("Captain America", 5)
        };

        foreach (SuperHero hero in heroes)
        {
            hero.Introduce();
            hero.Train(100000);
            
       }

    }
}
