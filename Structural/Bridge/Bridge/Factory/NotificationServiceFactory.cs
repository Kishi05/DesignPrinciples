using Bridge.Adapter;
using Bridge.Adapter.Interface;

namespace Bridge.Factory
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
