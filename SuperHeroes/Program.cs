namespace SuperHeroes;


public class SuperHero
{
    public string Name = "Unknown Name";
    public int PowerLevel = 1;

    public SuperHero(string name, int powerLevel)
    {
        Name = name;
        PowerLevel = powerLevel;
        Introduce();
    }

    public void Introduce()
    {
        System.Console.WriteLine($"My name is {Name}, power level: {PowerLevel}");

    }

    public void Taunt(Villain villain)
    {
        System.Console.WriteLine($"{Name} taunts {villain.Name}");

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

        SuperHero hero1 = new SuperHero("SuperMan", 1000);
        SuperHero hero2 = new SuperHero("Batman", 500);
        SuperHero hero3 = new SuperHero("Captain America", 5);


        Villain villain1 = new Villain("Thanos", 100000);
        Villain villain2 = new Villain("Joker", 100);

        hero1.Taunt(villain2);




    }
}
