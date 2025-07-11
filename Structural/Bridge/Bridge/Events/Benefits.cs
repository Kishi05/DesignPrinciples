using Bridge.Adapter.Interface;
using Bridge.Entity;

namespace Bridge.Events
{
    public class Benefits
    {
        private INotification _notification;
        public Benefits(INotification notification) => _notification = notification;
        public void sendMessage(User user, string message)
        {
            _notification.SendMessage(user, message);
        }
    }
}
