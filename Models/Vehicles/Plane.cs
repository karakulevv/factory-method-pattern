namespace FactoryMethodPattern.Models.Vehicles;

/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
class Plane : Transport
{
    public override void Deliver()
    {
        Console.WriteLine("Delivering by plane.");
    }
}