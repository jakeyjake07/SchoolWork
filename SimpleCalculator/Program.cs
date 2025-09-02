namespace SimpleCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose an operation (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.WriteLine("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());



        if (op == "+")
        {
            Add(num1, num2);
        }
        else if (op == "-")
        {
            Subtract(num1, num2);
        }
        else if (op == "*")
        {
            Mult(num1, num2);
        }
        else if (op == "/")
        {
            if (num2 != 0)
            {
                Divide(num1, num2);
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid operation.");
        }

    }

    static void Add(int num1, int num2)
    {
        int result = num1 + num2;
        System.Console.WriteLine("Result :" + result);
    }
    static void Subtract(int num1, int num2)
    {
        int result = num1 - num2;
        System.Console.WriteLine($"Result: {result}");
    }

    static void Mult(int num1, int num2)
    {
        int result = num1 * num2;
        System.Console.WriteLine($"Result: {result}");
    }

    static void Divide(int num1, int num2)
    {
        int result = num1 / num2;
        System.Console.WriteLine($"Result: {result}");
    }

}




