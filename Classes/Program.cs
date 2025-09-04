using System.Security.Cryptography.X509Certificates;

namespace Classes;

public class Human
{

    public string Name;
    public int Age;
    public int stepsWalked = 0;

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I'm {Age} years old.");
    }

    public void Walk(int amount)
    {

        stepsWalked += amount;
        Console.WriteLine($"{Name} took {amount} steps. {Name} have walked a total of {stepsWalked} steps.");
    }

    public void Greet(Human otherHuman)
    {
        Console.WriteLine($"{Name} greets {otherHuman.Name}");
    }

}

class Program
{
    static void Main(string[] args)
    {

        //Human1
        Human human1 = new Human();
        human1.Name = "Jakob";
        human1.Age = 31;
        human1.Introduce();




        //Human2
        Human human2 = new Human();
        human2.Name = "Sam";
        human2.Age = 29;
        human2.Introduce();


        human1.Greet(human2);



        /*
         //Human3
         Human human3 = new Human();
         human3.Name = "Frodo";
         human3.Age = 60;
         human3.Introduce();

         //Human4
         Human human4 = new Human();
         human4.Name = "Osama";
         human4.Age = 62;
         human4.Introduce(); */


    }
}
