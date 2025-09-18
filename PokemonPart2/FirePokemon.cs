using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonPart2
{
    public class FirePokemon : Pokemon
    {
        public FirePokemon(string name, int level, int hp) : base(name, level, hp)
        {

        }

        public override void Attack()
        {
            System.Console.WriteLine($"{Name} used Fireball!");
        }

    }
}