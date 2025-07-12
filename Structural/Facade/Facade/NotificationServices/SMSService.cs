// SMSService.cs
// -----------------------------------------------------------
// This is a third-party or legacy SMS sending service class.
// It uses Singleton pattern to ensure only one instance exists.
// This class is adapted via the Adapter Pattern (SMS class)
// to fit the INotification interface.
// -----------------------------------------------------------

namespace Facade.NotificationServices
{
    public class SMSService
    {
        private static SMSService? _instance;
        private static object _instanceLock = new object();
        public static SMSService Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new SMSService();
                    }
                }
                return _instance;
            }
        }
        public void SendMessage(string phoneNumber, string message)
        {
            Console.WriteLine($"SMS :\n");
            Console.WriteLine($"To : {phoneNumber} \nMessage :\n {message}\n");
        }

    }
}
