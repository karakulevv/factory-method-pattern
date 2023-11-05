namespace FactoryMethodPattern.Models.Vehicles;

/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
class Truck : Transport
{
    public override void Deliver()
    {
        Console.WriteLine("Delivering by truck.");
    }
}