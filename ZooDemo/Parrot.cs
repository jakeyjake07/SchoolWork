using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Parrot : Animal, ITrick
    {
        public Parrot(string name, int age, int startHp) : base(name, age, startHp)
        {
        }

        public override string Speak()
        {
            return "Caw Caw";
        }

        public override double DailyFoodKg()
        {
            return 0.12;
        }

        public string DoTrick()
        {
            return "Hello, I can mimic human speech";
        }


    }
}