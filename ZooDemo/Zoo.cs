using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Zoo
    {
        private List<Animal> animals = new List<Animal>();
        public void Add(Animal animal)
        {
            animals.Add(animal);
        }

        public void ListAll()
        {
            if (animals.Count == 0)
            {
                System.Console.WriteLine("No animals in the list.");
                return;
            }

            System.Console.WriteLine("--- Animal List ---");
            for (int i = 0; i < animals.Count; i++)
            {
                Animal a = animals[i];
                System.Console.WriteLine($"{i + 1}. {a.Info()}");
            }

        }


        public void AllSpeak()
        {
            System.Console.WriteLine("--- Animals Speaking ---");
            foreach (Animal a in animals)
            {
                System.Console.WriteLine($"{a.Name}: {a.Speak()}");
            }

        }

        public void ShowFeedingPlan()
        {
            System.Console.WriteLine("--- Feeding Plan (KG/Per day) ---");
            foreach (Animal a in animals)
            {
                System.Console.WriteLine($"{a.Name}: {a.DailyFoodKg()}kg");
            }
        }



        public void ShowTricks()
        {
            System.Console.WriteLine("--- Tricks ---");
            foreach (Animal a in animals)
            {
                ITrick t = a as ITrick;
                if (t != null)
                {
                    System.Console.WriteLine($"{a.Name}: {t.DoTrick()}");
                }
                else
                {
                    System.Console.WriteLine($"{a.Name} can't do tricks.");
                }
            }
        }

        public void TotalFoodKg()
        {
            double total = 0;
            foreach (Animal a in animals)
            {
                total += a.DailyFoodKg();
            }
            System.Console.WriteLine($"Total food needed: {total}kg");
        }


        public void ShowRunSpeed()
        {
            System.Console.WriteLine("--- Run Speed ---");
            foreach (Animal a in animals)
            {
                ICanRun r = a as ICanRun;
                if (r != null)
                {
                    System.Console.WriteLine($"{a.Name}: {r.RunSpeed()}km/h");
                }
                else
                {
                    System.Console.WriteLine($"{a.Name} can't run.");
                }
            }
        }
       

        
    }
}