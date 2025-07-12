// EmailService.cs
// -----------------------------------------------------------
// This is a third-party or custom email sending service class.
// Uses Singleton pattern to optimize reuse and resource management.
// Adapted via the Email Adapter to fit INotification interface.
// -----------------------------------------------------------

namespace Facade.NotificationServices
{
    public class EmailService
    {
        private static EmailService? _instance;
        private static object _instanceLock = new object();
        public static EmailService Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new EmailService();
                    }
                }
                return _instance;
            }
        }
        public void SendMessage(string from, string to, string body)
        {
            Console.WriteLine($"Email :\n");
            Console.WriteLine($"From: {from} \nTo : {to} \nMessage :\n\t{body}\n");
        }

    }
}
