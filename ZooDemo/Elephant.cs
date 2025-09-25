using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Elephant : Animal, ITrick, ICanRun
    {
        public Elephant(string name, int age, int startHp) : base(name, age, startHp)
        {
        }

        public override string Speak()
        {
            return "Toot Toot";
        }

        public override double DailyFoodKg()
        {
            return 15;
        }

        public string DoTrick()
        {
            return "I can dance";
        }

        public int RunSpeed()
        {
            return 30;
        }
    }
}