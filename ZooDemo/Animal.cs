using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooDemo
{
    public abstract class Animal
    {
        public static int TotalCount = 0;
        private int hp;
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int HP
        {
            get { return hp; }
            set
            {
                if (value < 0)
                {
                    hp = 0;
                }
                else
                {
                    hp = value;
                }
            }
        }

        protected Animal(string name, int age, int startHp)
        {
            Name = name;
            Age = age;
            HP = startHp;
            TotalCount++;
        }

        //Abstract, needs to be overridden
        public abstract string Speak();

        //Virtual, can be overriden
        public virtual double DailyFoodKg()
        {
            return 1.0;
        }

        //Standard, can not be overriden
        public string Info()
        {
            return $"{Name}, Age: {Age}, HP: {HP}";
        }

        public override string ToString()
        {
            return Info() + ", " + Speak();
        }
    
    }
}