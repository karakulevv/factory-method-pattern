using FactoryMethodPattern.MailFactories;

namespace FactoryMethodPattern.Models;

/// <summary>
/// Client class
/// </summary>
class Mail
{
    private readonly Transport transport;

    public Mail(MailFactory factory)
    {
        transport = factory.CreateTransport();
    }

    public void Send()
    {
        Console.Write("Mail: ");
        transport.Deliver();
    }
}