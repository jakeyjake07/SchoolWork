using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class Hero : Human
    {
        public int PowerLevel { get; set; }
        public Hero(string name, int age, string city, int powerLevel) : base(name, age, city)
        {
            PowerLevel = powerLevel;
        }

        public override string RoleDescription()
        {
            return $"My name is {Name} and I am a hero";
        }
    }
}