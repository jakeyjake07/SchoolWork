using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    public interface IAnimal
    {
        void MakeSound();
        void Eat();
        void Sleep();
    }
}