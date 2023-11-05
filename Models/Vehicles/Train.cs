namespace FactoryMethodPattern.Models.Vehicles;

/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
class Train : Transport
{
    public override void Deliver()
    {
        Console.WriteLine("Delivering by train.");
    }
}