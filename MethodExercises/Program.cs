namespace MethodExercises;


class Program
{
    static void Square(int num)
    {
        int result = num * num;
        Console.WriteLine($"Result: {result}");
        
    }

    static void Square(double num)
    {
        double result = num * num;
        Console.WriteLine($"Result: {result}");
    }

    static void SayGoodbye(string name = "friend")
    {
        System.Console.WriteLine($"Goodbye {name}!");
    }

    static void FindLargest(int[] numbers)
    {
        int largest = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }
        Console.WriteLine($"Largest number: {largest}");
    }
    static void IsAdult(int age)
    {
        bool isAdult = age >= 18;
        Console.WriteLine($"Is Adult: {isAdult}");

    }
    static void PrintProfile(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
    static void SayHello(string name)
    {
        Console.WriteLine($"Hello {name}!");
    }
    static void Add(int num1, int num2)
    {
        int result = num1 + num2;
        Console.WriteLine($"Result: {result}");
    }
    static void Main(string[] args)
    {
        SayHello("Jakob");
        SayHello("Sam");
        SayHello("Frodo");

        Add(2, 3);

        PrintProfile("Jakob", 31);

        IsAdult(7);

        FindLargest(new int[] { 1, 2, 3, 4, 5 });


        Square(5);
        SayGoodbye();

    }

}
