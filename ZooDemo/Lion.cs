using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Lion : Animal, ICanRun
    {
        public Lion(string name, int age, int startHp) : base(name, age, startHp)
        {
        }

        public override string Speak()
        {
            return "Roar!";
        }

        public override double DailyFoodKg()
        {
            return 7.5;
        }

        public int RunSpeed()
        {
            return 40;
        }
    }

}