using FactoryMethodPattern.Models;
using FactoryMethodPattern.Models.Vehicles;

namespace FactoryMethodPattern.MailFactories;

/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
class GroundMailFactory : MailFactory
{
    private readonly string transportType;

    public GroundMailFactory(string transportType)
    {
        this.transportType = transportType;
    }

    public override Transport CreateTransport()
    {
        switch (transportType)
        {
            case "Truck":
                return new Truck();
            case "Train":
                return new Train();
            default:
                throw new ArgumentException("Invalid transport type for GroundMail.");
        }
    }
}