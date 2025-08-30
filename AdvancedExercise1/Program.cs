using System.Globalization;
using System.Security.Cryptography;
using System.Transactions;

namespace AdvancedExercise1;

class Program
{
    static void Main(string[] args)
    {
        /*   Console.WriteLine("Please enter your age:");
          int age = int.Parse(Console.ReadLine());

          if (age > 18)
          {
            Console.WriteLine("You are an adult.");

          }
          else
          {
            Console.WriteLine("You are a minor.");
          }

          Console.WriteLine("What's your hobby?");
          string hobby = Console.ReadLine();

          if (hobby.ToLower() == "reading")
          {
            Console.WriteLine("Reading is a great hobby!");
          }
          else
          {
            Console.WriteLine("That's a cool hobby.");
          }

          Console.WriteLine("Do you like Pizza? (True/False)");
          bool likesPizza = bool.Parse(Console.ReadLine());
          if (likesPizza)
          {
            Console.WriteLine("Pizza is delicious!");
          }
          else
          {
            Console.WriteLine("More pizza for me then!");
          }
       */

        /*    string firstname = "Alice";
           int age = 21;
           bool isStudent = false;

           if (isStudent == true)
           {
             Console.WriteLine($"{firstname} is {age} years old and is a student.");
           }
           else
           {
             Console.WriteLine($"{firstname} is {age} years old and is not a student.");
           } */


        /* char grade = 'W';
        switch (grade)
        {
          case 'A':
            Console.WriteLine("Excellent!");
            break;
          case 'B':
            Console.WriteLine("Well done!");
            break;
          case 'C':
            Console.WriteLine("You passed.");
            break;
          case 'D':
            Console.WriteLine("Better try again.");
            break;
          case 'F':
            Console.WriteLine("Failed.");
            break;

          default:
            Console.WriteLine("Invalid grade.");
            break;
        }

        int favNum = 7;
        switch (favNum)
        {
          case 1:
          case 3:
          case 5:
          case 7:
          case 9:
            Console.WriteLine("Your favorite number is odd.");
            break;
          case 2:
          case 4:
          case 6:
          case 8:
          case 10:
            Console.WriteLine("Your favorite number is even.");
            break;
          default:
            Console.WriteLine("Your favorite number is out of range.");
            break; */

        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your last name:");
        string lastname = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your year of birth:");
        int yearOfBirth = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your height in meters:");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("Enter your favorite number:");
        int favNumber = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Are you a student? (true/false)");
        bool isStudent = bool.Parse(Console.ReadLine());

        System.Console.WriteLine("Do you like pizza? (Yes/No)");
        string likesPizza = Console.ReadLine();


        System.Console.WriteLine("Enter your average grade (A-F):");
        char averageGrade = char.Parse(Console.ReadLine());


        System.Console.WriteLine("\n--- Profile Card ---");
        System.Console.WriteLine($"Name: {firstName} {lastname}");
        System.Console.WriteLine($"Age: {age} (Born: {yearOfBirth})");
        System.Console.WriteLine($"Height: {height}m");
        System.Console.WriteLine($"Favorite Number: {favNumber}");
        System.Console.WriteLine($"Student: {isStudent}");
        System.Console.WriteLine($"Likes Pizza: {likesPizza}");
        System.Console.WriteLine($"Average Grade: {averageGrade}");
        System.Console.WriteLine("--------------------\n");


        if (likesPizza == "Yes" || likesPizza == "yes")
        {
            Console.WriteLine("You like pizza!");
        }
        else
        {
            Console.WriteLine("You don't like pizza. More pizza for me!");

        }

        if (age >= 18)
        {
            System.Console.WriteLine("You are an adult.");
        }
        else
        {
            System.Console.WriteLine("You are a minor.");
        }

        if (height > 1.80)
        {
            System.Console.WriteLine("You are tall.");
        }
        else
        {
            System.Console.WriteLine("You are average or below.");
        }

        switch (favNumber)
        {
            case 7:
                System.Console.WriteLine("7 is a lucky number!");
                break;

            case 10:
                System.Console.WriteLine("Perfect 10!");
                break;

            case 42:
                System.Console.WriteLine("The answer to life, the universe and everything.");
                break;

            default:
                System.Console.WriteLine("That's a nice number.");
                break;
        }

        switch (averageGrade)
        {
            case 'A':
                System.Console.WriteLine("Excellent!");
                break;

            case 'B':
                System.Console.WriteLine("Well done!");
                break;

            case 'C':
                System.Console.WriteLine("You passed.");
                break;

            case 'D':
                System.Console.WriteLine("Better try again.");
                break;

            case 'F':
                System.Console.WriteLine("Failed.");
                break;

            default:
                System.Console.WriteLine("Invalid grade.");
                break;
        }


        System.Console.WriteLine($"Thanks for using the program, {firstName}! Goodbye!");



    }


}
