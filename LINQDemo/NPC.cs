using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class NPC : Human
    {   
        public string Occupation { get; set; }
        public NPC(string name, int age, string city, string occupation) : base(name, age, city)
        {
            Occupation = occupation;
        }

        public override string RoleDescription()
        {
            return $"{Name} works as a {Occupation} in {City}.";
        }
    }
}