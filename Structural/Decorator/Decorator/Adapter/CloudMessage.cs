// CloudMessage.cs
// -----------------------------------------------------------
// Adapter class for CloudService (chat/messaging platform).
// Implements INotification to abstract API usage.
// Singleton pattern ensures single instance during app lifetime.
// -----------------------------------------------------------

using Decorator.Adapter.Interface;
using Decorator.Entity;
using Decorator.Factory;
using Decorator.NotificationServices;

namespace Decorator.Adapter
{
    public class CloudMessage : INotification
    {
        public NotificationServiceType NotificationServiceType { get; } = NotificationServiceType.Cloud;
        private static CloudMessage? _instance;
        private static object _instanceLock = new object();

        public static CloudMessage Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new CloudMessage();
                    }
                }
                return _instance;
            }
        }

        public void SendMessage(User user, string message)
        {
            CloudService.Instance.SendMessage(user.PhoneNumber, message);
        }
    }
}
