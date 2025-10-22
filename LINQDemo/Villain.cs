using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class Villain : Human
    {
        public string EvilPlan { get; set; }
        public Villain(string name, int age, string city, string evilPlan) : base(name, age, city)
        {
            EvilPlan = evilPlan;
        }

        public override string RoleDescription()
        {
            return "Muahahhahahaha";
        }
    }
}