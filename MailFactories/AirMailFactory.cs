using FactoryMethodPattern.Models;
using FactoryMethodPattern.Models.Vehicles;

namespace FactoryMethodPattern.MailFactories;

/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
class AirMailFactory : MailFactory
{
    public override Transport CreateTransport()
    {
        return new Plane();
    }
}