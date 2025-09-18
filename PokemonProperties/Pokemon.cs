using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PokemonProperties
{
    public class Pokemon
    {
        //Auto properties, PascalCase
        public string Name { get; private set; }
        public int Level { get; set; }

        //Private field, encapsulation, totally private, can only be changed within the same class
        private int hp;

        //Property with private backing field
        public int Hp
        {
            get { return hp; }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("HP can't be less than 0.");
                    hp = 0;
                }
                else
                {
                    hp = value;
                }
            }
        }


        public Pokemon(string name, int level, int startHp)
        {
            Name = name;
            Level = level;
            hp = startHp;
        }
       
       
       
       
        public string Info()
        {
            return $"{Name} is Level: {Level} and HP: {hp}";
        }















        public void Evolution(Pokemon pokemon, string name)
        {
            pokemon.Name = name;
        }


    }



}
