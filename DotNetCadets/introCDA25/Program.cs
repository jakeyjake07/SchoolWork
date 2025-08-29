using System.Globalization;



/*  Console.WriteLine("1. Create variables and print them");

        Console.WriteLine("2. Combine variables into sentences");

        Console.WriteLine("3. Make decisions with if else");
        System.Console.WriteLine();


        //These are strings
        string firstName = "Jakob";
        string lastName = "El Saidi";
        string fullName = firstName + " " + lastName;
        string hobby = "gaming";

        //Integers
        int age = 31;
        int favNumber = 7;
        int year = 2025;


        //Double variables
        double temperature = 22.5;
        double pi = 3.14;
        double milkPrice = 19.95;

        //Boolean variables
        bool isHungry = true;
        bool likesMonster = false;
        bool hasPet = false;

        //character variable
        char grade = 'A';
        char currencySymbol = '$';

        //String concatenation
        Console.WriteLine("Hi my name is " + fullName + " and I'm " + age + " years old. My favorite hobby is " + hobby + ".");
        Console.WriteLine($"Hi my name is {fullName} and I'm {age} years old. My favorite hobby is {hobby}."); */




/* char grade = 'A';


if (grade == 'A')
{
    Console.WriteLine("Excellent!");
}
else if (grade == 'B')
{
    Console.WriteLine("Well done, you passed!");
}
else
{
    Console.WriteLine("You need to improve.");
} */


Console.WriteLine("What's your name?");
Console.ReadLine();
string firstName = Console.ReadLine();
Console.WriteLine($"Hello {firstName}, welcome to the C# world!");
Console.WriteLine("What's your last name?");
Console.ReadLine();
string lastName = Console.ReadLine();
Console.WriteLine($"Hello {firstName} {lastName}, welcome!");