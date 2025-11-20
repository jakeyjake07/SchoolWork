using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesSQL
{
    public class CharacterService
    {
        private readonly AppDbContext db;
        public CharacterService()
        {
            db = new AppDbContext();
        }


        public void AddHero(Hero hero)
        {
            db.Heroes.Add(hero);
            db.SaveChanges();
            System.Console.WriteLine($"Hero {hero.Name} added successfully");
        }

        public void AddVillain(Villain villain)
        {
            db.Villains.Add(villain);
            db.SaveChanges();
            System.Console.WriteLine($"Villain {villain.Name} added successfully");
        }


        public List<Hero> GetHeroes()
        {
            return db.Heroes.ToList();
        }

        public List<Villain> GetVillains()
        {
            return db.Villains.ToList();
        }
    }
}