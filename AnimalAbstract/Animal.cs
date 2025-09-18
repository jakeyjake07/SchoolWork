using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    public abstract class Animal
    {

        //Abstract Method
        //Must be overriden
        public abstract void MakeSound();



        //Virtual Method
        //Can be overriden
        public virtual void Sleep()
        {
            System.Console.WriteLine("The animal is sleeping");
        }


        //Normal method
        //Cannot be overriden
        public void Eat()
        {
            System.Console.WriteLine("The animal is eating");
        }

    }
}