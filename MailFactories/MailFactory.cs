using FactoryMethodPattern.Models;

namespace FactoryMethodPattern.MailFactories;

/// <summary>
/// The 'Creator' abstract class
/// </summary>
abstract class MailFactory
{
    public abstract Transport CreateTransport();
}