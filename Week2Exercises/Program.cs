using System.Globalization;

namespace Week2Exercises;

class Program
{
    static void Main(string[] args)
    {
        /*         System.Console.WriteLine("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (age >= 18 && age < 80)
                {
                    System.Console.WriteLine("You are allowed to drive.");
                }
                else
                {
                    System.Console.WriteLine("You are not allowed to drive.");
                }

                System.Console.WriteLine("Enter the day of the week: ");
                string day = Console.ReadLine().ToLower();

                if (day == "saturday" || day == "sunday")
                {
                    System.Console.WriteLine("It's the weekend.");
                }
                else
                {
                    System.Console.WriteLine("It's not the weekend.");
                } */



        /*   System.Console.WriteLine("Welcome to the Pizza Shop!");
          System.Console.WriteLine("Do you want cheese on your pizza? (yes/no)");
          string cheese = Console.ReadLine().ToLower();
          System.Console.WriteLine("Do you want pepperoni on your pizza? (yes/no)");
          string pepperoni = Console.ReadLine().ToLower();

          if (cheese == "yes" && pepperoni == "yes")
          {
              System.Console.WriteLine("Cheese & Pepperoni Pizza coming up!");
          }

          else if (cheese == "yes" || pepperoni == "yes")
          {
              System.Console.WriteLine("One topping pizza coming up!");
          }


          else
          {
              System.Console.WriteLine("No toppings pizza coming up!");
          } */


        /* 
       System.Console.WriteLine("Are you a student? (yes/no)");
       string student = Console.ReadLine().ToLower();
       System.Console.WriteLine("Do you have a student card? (yes/no)");
       string studentCard = Console.ReadLine().ToLower();

       if (student == "yes" && studentCard == "yes")
       {
           System.Console.WriteLine("Access Granted!");
       }

       else
       {
           System.Console.WriteLine("Access Denied!");
       } */


        /*   System.Console.WriteLine("Enter your age: ");
          int age = int.Parse(Console.ReadLine());

          if (age < 13)
          {
              System.Console.WriteLine("You are a child.");
          }

          else if (age >= 13 && age < 20)
          {
              System.Console.WriteLine("You are a teenager.");
          }

          else
          {
              System.Console.WriteLine("You are an adult.");
          } */


        /*  System.Console.WriteLine("Whats the temperature outside?");
         double temp = double.Parse(Console.ReadLine());

         if (temp < 0)
         {
             System.Console.WriteLine("It's freezing outside!");
         }

         else if (temp >= 0 && temp < 15)
         {
             System.Console.WriteLine("It's cold outside!");
         }

         else if (temp >= 15 && temp <= 30)
         {
             System.Console.WriteLine("It's warm outside!");
         }

         else
         {
             System.Console.WriteLine("It's hot outside!");
         } */



        /*  System.Console.WriteLine("Enter your exam score (0-100): ");
         int score = int.Parse(Console.ReadLine());

         if (score >= 90 && score <= 100)
         {
             System.Console.WriteLine("You got an A!");
         }

         else if (score >= 75 && score < 90)
         {
             System.Console.WriteLine("You got a B!");
         }

         else if (score >= 50 && score < 75)
         {
             System.Console.WriteLine("You got a C!");
         }

         else if (score <= 0 && score < 50)
         {
             System.Console.WriteLine("You got an F!");
         }

         else
         {
             System.Console.WriteLine("Invalid score!");
         } */

        /*  System.Console.WriteLine("Enter a number: ");
         int num = int.Parse(Console.ReadLine());

         if (num % 2 == 0)
         {
             System.Console.WriteLine("The number is even.");
         }

         else
         {
             System.Console.WriteLine("The number is odd.");
         } */


        /*     int i = 10;
            while (i >= 1)
            {
                System.Console.WriteLine(i);
                i--;
            } */


        /*   System.Console.WriteLine("Type something");
          string input = Console.ReadLine().ToLower();

          while (input != "stop")
          {
              System.Console.WriteLine("Type Something");
              input = Console.ReadLine().ToLower();
          } */




        /*      int secretNumber = 7;
             int maxTries = 3;

             System.Console.WriteLine($"Guess the number between 1 and 10 in {maxTries} tries.");
             int tries = 0;
             int guess = 0;

             while (tries < maxTries && guess != secretNumber)
             {
                 System.Console.WriteLine("Enter your guess: ");
                 guess = int.Parse(Console.ReadLine());
                 tries++;

                 if (guess == secretNumber)
                 {
                     System.Console.WriteLine($"You guessed the number in {tries} tries!");
                     break;
                 }
                 else if (tries < maxTries)
                 {
                     System.Console.WriteLine($"Wrong guess. You have {maxTries - tries} tries left.");
                 }
             }

             if (guess != secretNumber)
             {
                 System.Console.WriteLine($"You lost. The number was {secretNumber}.");
             } */



        /*  int total = 0;
         int num;

         System.Console.WriteLine("Enter a number to add (0 to quit): ");
          num = int.Parse(Console.ReadLine());

         while (num != 0)
         {
             total += num;
             num = int.Parse(Console.ReadLine());
         }

        System.Console.WriteLine($"The total is {total}"); */

        /* int pin = 1234;
       int maxTries = 3;
       int tries = 1;

       System.Console.WriteLine("Enter your PIN: ");
       int userPin = int.Parse(Console.ReadLine());

       while (userPin != pin)
       {
           System.Console.WriteLine($"Incorrect PIN. Try again. You have {maxTries - tries} tries left.");
           userPin = int.Parse(Console.ReadLine());
           tries++;

           if (tries >= maxTries)
           {
               System.Console.WriteLine("Access Denied!");
               return;
           }

       }

       System.Console.WriteLine("Access Granted!"); */




        /*   for (int i = 2; i <= 20; i = i + 2)
          {
              System.Console.WriteLine(i);
          } */



        /*     System.Console.WriteLine("Enter a number and let's multiply it from 1 to 10:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine($"{number} * {i} = {number * i}");
            } */


        /*  for (int i = 10; i >= 1; i--)
         {
             System.Console.WriteLine(i);

         }

          System.Console.WriteLine("blastoff!"); */


        /*     int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            System.Console.WriteLine($"The total sum is {sum}");

            for (string star = "*"; star.Length <= 5; star += "*")
            {
                System.Console.WriteLine(star);
            } */


        /*  System.Console.WriteLine("Enter a number and lets calculate its factorial:");
         int number = int.Parse(Console.ReadLine());

         int factorial = 1;
         for (int i = 1; i <= number; i++)
         {
             factorial *= i;
         }
         System.Console.WriteLine($"The factorial of {number} is {factorial}"); */

        /*  string[] fruitList = { "apple", "banana", "cherry" };

         for (int i = 0; i < fruitList.Length; i++)
         {
             System.Console.WriteLine(fruitList[i]);
         } */


        /* int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[1];
        }

        int average = sum / numbers.Length;
        System.Console.WriteLine($"The average is {average}"); */


        /* int[] numbers = { 32, 41, 12, 9, 94 };
        int largest = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }
        System.Console.WriteLine($"The largest number is {largest}");
 */

        /*  int[] numbers = { 1, 2, 3, 4, 5 };
         System.Console.WriteLine("Array in reverse order:");

         for (int i = numbers.Length - 1; i >= 0; i--)
         {
             System.Console.WriteLine(numbers[i]);
         } */


        /*     int[] numbers = { 1, 2, 3, 4, 5 };
            System.Console.WriteLine("Check if the number exists in the array:");
            bool exists = false;


            while (exists == false)
            {

                int numberCheck = int.Parse(Console.ReadLine());

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == numberCheck)
                    {
                        exists = true;
                        break;
                    }
                }


                if (exists)
                {
                    System.Console.WriteLine($"The number {numberCheck} exists in the array.");
                }

                else
                {
                    System.Console.WriteLine($"The number {numberCheck} does not exist in the array.");
                }
            } */


        System.Console.WriteLine("Let's create a list of hobbies!");
        System.Console.WriteLine("Enter a hobby and type stop when you are done:");

        List<string> hobbies = new List<string>();

        while (true)
        {
            string hobby = Console.ReadLine();

            if (hobby.ToLower() == "stop")
            {
                break;
            }

            hobbies.Add(hobby);
        }

        foreach (string hobby in hobbies)
        {
            System.Console.WriteLine(hobby); 
        }



    }


}
