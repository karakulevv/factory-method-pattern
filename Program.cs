using FactoryMethodPattern.MailFactories;
using FactoryMethodPattern.Models;

namespace FactoryMethodPattern;

/// <summary>
/// Program startup class for Real-World 
/// Factory Method Design Pattern.
/// </summary>
static class Program
{
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    public static void Main(string[] args)
    {
        // AirMail using Plane
        MailFactory airMailFactory = new AirMailFactory();
        Mail airMail = new Mail(airMailFactory);
        airMail.Send();

        // GroundMail using Truck
        MailFactory groundMailFactory1 = new GroundMailFactory("Truck");
        Mail groundMail1 = new Mail(groundMailFactory1);
        groundMail1.Send();

        // GroundMail using Train
        MailFactory groundMailFactory2 = new GroundMailFactory("Train");
        Mail groundMail2 = new Mail(groundMailFactory2);
        groundMail2.Send();

        Console.ReadKey();
    }
}