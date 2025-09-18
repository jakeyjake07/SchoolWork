using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PokemonPart2
{
    public abstract class Pokemon
    {

        public string Name { get; private set; }
        public int Level { get; private set; }
        public int HP { get; private set; }


        public Pokemon(string name, int level, int hp)
        {
            Name = name;
            Level = level;
            HP = hp;
        }

        public abstract void Attack();

        public void Info()
        {
            System.Console.WriteLine($"{Name} is level: {Level}, and has {HP}hp");
        }

    }        

 }
