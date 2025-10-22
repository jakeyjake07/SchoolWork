using System.IO.Compression;

namespace LINQDemo;

class Program
{

    static void Main(string[] args)
    {

        List<Human> humans = new List<Human>()
        {
            new Hero("Superman", 30, "New York", 100),
            new Villain("Thanos", 100, "Malmö", "Destroy the Universe"),
            new NPC("Bob", 45, "Stockholm", "Trucker"),
            new Hero("Captain America", 77, "New York", 5),
            new Villain("Joker", 28, "Gotham City", "Harley Quinn"),
            new NPC("Hermano", 12, "London", "Student"),
            new NPC("Sabrina", 24, "London", "Teacher"),
            new Hero("Flash", 29, "Gotham City", 80)
        };





        var heroes = humans.OfType<Hero>();
        var villains = humans.OfType<Villain>();
        var npcs = humans.OfType<NPC>();


        var grouped = humans.GroupBy(h => h.GetType().Name);
        System.Console.WriteLine("Grouped by type: ");
        foreach (var g in grouped)
        {
            System.Console.WriteLine($"{g.Key}: {g.Count()} chracters");
        }

        /*  var strongHeroes = humans.OfType<Hero>()
         .Where(h => h.PowerLevel >= 50)
         .OrderByDescending(h => h.Name)
         .Select(h => h.Name)
         .ToList();

         System.Console.WriteLine("Strong Heroes: ");
         foreach (var h in strongHeroes)
         {
             System.Console.WriteLine(h);
         } */

        /*    System.Console.WriteLine("Heroes: ");
           foreach (var h in heroes)
           {
               System.Console.WriteLine(h.RoleDescription());
           }


           var humansInLondon = humans
           .Where(h => h.City == "London")
           .OrderBy(h => h.Name)
           .ToList();

           System.Console.WriteLine("Humans in London: ");
           foreach (var h in humansInLondon)
           {
               System.Console.WriteLine(h.Name);
           }  */

        /*  //Where
         var adults = humans.Where(human => human.Age >= 18).ToList();

         foreach(Human h in adults)
         {
             System.Console.WriteLine(h.Name);
         }
         */


        /*   //Orderby
          var sorted = humans.OrderBy(human => human.Age).ToList();

          foreach (Human h in sorted)
          {
              System.Console.WriteLine($"{h.Name} {h.Age} {h.City}");
          }

          System.Console.WriteLine("---");

          //OrderbyDescending
          var sortedDescending = humans.OrderByDescending(human => human.Age).ToList();

          foreach (Human h in sortedDescending)
          {
              System.Console.WriteLine($"{h.Name} {h.Age} {h.City}");
          } */

        /* //Select
        var names = humans.Select(human => human.Name).ToList();
        foreach (string name in names)
        {
            System.Console.WriteLine(name);
        } */

        /*    //Distinct
           var cities = humans.Select(h => h.City).Distinct().ToList();

           foreach (string city in cities)
           {
               System.Console.WriteLine(city);
           }
        */

        /* //First
        var firstSthlm = humans.First(h => h.City == "Gävle");
        System.Console.WriteLine(firstSthlm.Name); */

        /*  var notFound = humans.FirstOrDefault(h => h.City == "Göteborg");
         System.Console.WriteLine(notFound.Name); */

        /* //Any
        var isSomeoneAdult = humans.Any(h => h.Age >= 18);
        var isEveryoneAdult = humans.All(h => h.Age >= 18);
        System.Console.WriteLine(isEveryoneAdult); */




        /* var groupByCity = humans.GroupBy(h => h.City);
        foreach (var group in groupByCity)
        {
            System.Console.WriteLine(group.Key);
            foreach (var human in group)
            {
                System.Console.WriteLine($"  {human.Name}");
            }
        } */

        /* var top3 = humans.OrderBy(h => h.Age).Take(3);
        foreach (var human in top3)
        {
            System.Console.WriteLine(human.Name);
        }

        var skip2 = humans.OrderBy(h => h.Age).Skip(2);
        foreach (var human in skip2)
        {
            System.Console.WriteLine(human.Name);
        } */


        /*  var result = humans
         .Where(h => h.City == "Göteborg" && h.Age >= 18)
         .OrderBy(h => h.Name)
         .ToList();
         foreach(Human h in result)
         {
             System.Console.WriteLine($"{h.Name} {h.Age}");
         } */

    }


}


