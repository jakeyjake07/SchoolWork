using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    public class Cats : Animal
    {
        //Needs to override the abstract method
        public override void MakeSound()
        {
            System.Console.WriteLine("Meow!");
        }


        //Does not need sleep method, because it's virtual


    }
    
}