// SplitSmart
//
// What was the total cost? -> 374.49
// How many people to split the bill? -> 4
//
// Each person should pay: 90.00 kr
// Did someone already pay more than the rest? y/n: yes
//how much is the person owed?



/* 
int
boolean
float / double / decimal
strings "Hello world!"
char 'A'
 */

using System.Globalization;
using System.Runtime.Intrinsics.Arm;

Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;






/* System.Console.WriteLine("Type something and press Enter: ");
string input = Console.ReadLine();
System.Console.WriteLine("You typed: " + input); */


System.Console.WriteLine("Welcome to SplitSmart!\n");
System.Console.Write("What was total cost? ");
double totalCost = double.Parse(Console.ReadLine());

System.Console.WriteLine("How many people to split the bill?");
int people = int.Parse(Console.ReadLine());

double costPerPerson = totalCost / people;
System.Console.WriteLine($"Each person should pay: {totalCost / people:f2} kr");

System.Console.Write("Did someone already pay more than the rest? Y/N: ");
string answer = Console.ReadLine().ToUpper();

if (answer == "Y")
{
    System.Console.WriteLine("How much did the person pay? ");
    double amountPaid = double.Parse(Console.ReadLine());

    double balance = amountPaid - costPerPerson;
    balance = Math.Round(balance, 2);

    System.Console.WriteLine();
    if (balance > 0)
    {
        System.Console.WriteLine($"The person is owed {balance:f2} kr");
    }
    else if (balance < 0)
    {
        System.Console.WriteLine($"The person owes {-balance:f2} kr");
    }
    else
    {
        System.Console.WriteLine("The person is settled up.");
    }
}