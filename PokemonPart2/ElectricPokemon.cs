using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonPart2
{
    public class ElectricPokemon : Pokemon
    {
        public ElectricPokemon(string name, int level, int hp) : base(name, level, hp)
        {

        }

        public override void Attack()
        {
            System.Console.WriteLine($"{Name} used Thunderbolt!");
        }
    }

    
}