
/// <summary>
/// Factory class responsible for returning concrete notification adapters
/// based on the <see cref="NotificationServiceType"/> enum.
/// Implements the Factory pattern to decouple service instantiation.
/// </summary>

using Decorator.Adapter;
using Decorator.Adapter.Interface;

namespace Decorator.Factory
{
    public enum NotificationServiceType
    {
        SMS = 1,
        Email = 2,
        Cloud = 3
    }
    public class NotificationServiceFactory
    {
        public static INotification GetServe(NotificationServiceType serviceType)
        {
            switch (serviceType)
            {
                case NotificationServiceType.SMS:
                    return SMS.Instance;
                    
                case NotificationServiceType.Email:
                    return Email.Instance;

                case NotificationServiceType.Cloud:
                    return CloudMessage.Instance;

                default:
                    throw new ArgumentException("Invalid Service Type");
            }
        }
    }
}
