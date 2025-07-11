// CloudService.cs
// -----------------------------------------------------------
// This service simulates sending messages via a cloud-based
// chat or messaging service (e.g., WhatsApp, Firebase, etc.).
// Follows Singleton pattern for consistent instance usage.
// Adapted into INotification interface via CloudMessage Adapter.
// -----------------------------------------------------------

namespace Adapter.NotificationServices
{
    public class CloudService
    {
        private static CloudService? _instance;
        private static object _instanceLock = new object();
        public static CloudService Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new CloudService();
                    }
                }
                return _instance;
            }
        }
        public void SendMessage(string phoneNumber, string message)
        {
            Console.WriteLine($"Cloud :\n");
            Console.WriteLine($"{phoneNumber} : {message}\n");
        }
    }
}
