// SMS.cs
// -----------------------------------------------------------
// Adapter class for the legacy/third-party SMSService.
// Implements INotification to unify its API.
// Uses Singleton pattern for efficiency and control.
// -----------------------------------------------------------

using Bridge.Adapter.Interface;
using Bridge.Entity;
using Bridge.NotificationServices;

namespace Bridge.Adapter
{
    public class SMS : INotification
    {
        private static SMS? _instance;
        private static object _instanceLock = new object();
        public static SMS Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new SMS();
                    }
                }
                return _instance;
            }
        }
        public void SendMessage(User user, string message)
        {
            SMSService.Instance.SendMessage(user.PhoneNumber, message);
        }
    }
}
