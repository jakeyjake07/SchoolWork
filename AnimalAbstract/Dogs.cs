using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    public class Dogs : Animal
    {
        //Must exist or else error
        public override void MakeSound()
        {
            System.Console.WriteLine("Woof!");
        }

        //Regular method
        //Can be overriden, else standard method

        public override void Sleep()
        {
            System.Console.WriteLine("The dog is sleeping.");
        }

    }

}