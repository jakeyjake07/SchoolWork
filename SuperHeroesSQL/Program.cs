namespace SuperHeroesSQL;

class Program
{
    static void Main(string[] args)
    {
        var dbService = new CharacterService();

        var heroes = dbService.GetHeroes();
        foreach (var hero in heroes)
        {
            System.Console.WriteLine($"{hero.Id}. {hero.Name}");
        }

        var villains = dbService.GetVillains();
        foreach (var villain in villains)
        {
            System.Console.WriteLine($"{villain.Id}. {villain.Name}");
        }


    }
}
