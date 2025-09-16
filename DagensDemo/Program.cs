
namespace DagensDemo;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.Brand = "Ferrari";
        car1.Speed = 200;

        Car car2 = new Car();
        car2.Brand = "Lamborghini";
        car2.Speed = 220;

        Bicycle bicycle1 = new Bicycle();
        bicycle1.HasBell = true;
        bicycle1.Brand = "Crescent";

        SnowBoard snowBoard1 = new SnowBoard();
        snowBoard1.Brand = "Tony Hawk Pro Snow";


        List<Vehicle> ProductCatalog = new List<Vehicle>();
        ProductCatalog.Add(car1);
        ProductCatalog.Add(car2);
        ProductCatalog.Add(bicycle1);
        ProductCatalog.Add(snowBoard1);

        System.Console.WriteLine("Welcome to our vehicle shop!");

        foreach (Vehicle v in ProductCatalog)
        {
            Console.WriteLine(v.GetInfo());
        }



    }
}


class Vehicle
{
    public int Speed = 0;
    public string Brand;

    public virtual string GetInfo()
    {
        return $"Brand: {Brand}, Speed: {Speed}";
    }

    public void GoForward()
    {
        System.Console.WriteLine("Vehicle is going forward");
    }

}


class Car : Vehicle
{
    public int Wheels = 4;
    public override string GetInfo()
    {
        return $"Brand: {Brand}, Speed: {Speed}, Wheels: {Wheels}";
    }

}

class Bicycle : Vehicle
{
    public bool HasBell;

    public override string GetInfo()
    {
        return $"The bicycle {Brand} has a bell: {HasBell}";
    }

}

class SnowBoard : Vehicle
{
    public override string GetInfo()
    {
        return $"The snowboard {Brand} was used by Tony Hawk";
    }

}