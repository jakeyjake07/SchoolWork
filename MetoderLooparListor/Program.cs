namespace MetoderLooparListor;

class Program
{
    static void Main(string[] args)

    {



        // Console.WriteLine("Counting up from 1 to 5");

          //For Loop
        /*   for (int i = 1; i <= 5; i++)
          {
              Console.WriteLine(i);
          } */



        /* //While Loop
        int i = 1;
        while (i <= 5)
        {
            Console.WriteLine(i);
            i++;
        }
         */



        //Arrays
        string[] fruitList = { "Apple", "Banana", "Orange", "Mango", "Grape" };
        int[] favNumbers = { 3, 7, 10, 32, 99 };
        /*    Console.WriteLine(fruitList[1]);
           Console.WriteLine(favNumbers[3]); */


        /*    //Foreach loop
           foreach (int number in favNumbers)
           {
               Console.WriteLine(number);

           }

           foreach (string fruit in fruitList)
           {
               Console.WriteLine(fruit);
           } */


            //For loop in lists
        for (int i = 0; i < favNumbers.Length; i++)
        {
            Console.WriteLine(favNumbers[i]);
        }

    }
}
