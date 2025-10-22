using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQDemo
{
    public abstract class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Human(string name, int age, string city)
        {

            Name = name;
            Age = age;
            City = city;
        }

        public abstract string RoleDescription();
        
    
    }


   

}
