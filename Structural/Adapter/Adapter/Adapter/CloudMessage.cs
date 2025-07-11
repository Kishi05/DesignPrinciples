// CloudMessage.cs
// -----------------------------------------------------------
// Adapter class for CloudService (chat/messaging platform).
// Implements INotification to abstract API usage.
// Singleton pattern ensures single instance during app lifetime.
// -----------------------------------------------------------

using Adapter.Adapter.Interface;
using Adapter.Entity;
using Adapter.NotificationServices;

namespace Adapter.Adapter
{
    public class CloudMessage : INotification
    {
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
        public void SendMessage(User user)
        {
            CloudService.Instance.SendMessage(user.PhoneNumber, "Welcome to Adapter Design Pattern");
        }
    }
}
