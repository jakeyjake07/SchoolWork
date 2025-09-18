using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PokemonProperties
{
    public class Trainer
    {
        //Auto property
        public string Name { get; private set; }

        //Field
        private List<Pokemon> team = new List<Pokemon>();



        public Trainer(string name)
        {
            Name = name;
        }



        public void AddPokemon(Pokemon p)
        {
            team.Add(p);
        }

        public void ShowTeam()
        {
            System.Console.WriteLine($"{Name}'s Team: ");
            foreach (Pokemon p in team)
            {
                System.Console.WriteLine(p.Info());
            }
        }

    }



}