// Email.cs
// -----------------------------------------------------------
// Adapter class for the EmailService.
// Converts the INotification interface call to EmailService format.
// Singleton instance exposed for consistent reuse.
// -----------------------------------------------------------

using Bridge.Adapter.Interface;
using Bridge.Entity;
using Bridge.NotificationServices;

namespace Bridge.Adapter
{
    public class Email : INotification
    {
        private static Email? _instance;
        private static object _instanceLock = new object();
        public static Email Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Email();
                    }
                }
                return _instance;
            }
        }
        public void SendMessage(User user, string message)
        {
            EmailService.Instance.SendMessage("designPatter@dp.com", user.Email, message);
        }
    }
}
