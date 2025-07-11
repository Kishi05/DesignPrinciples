using Bridge.Adapter.Interface;
using Bridge.Entity;

namespace Bridge.Events
{
    public class WelcomeMessage
    {
        private INotification _notification;
        public WelcomeMessage(INotification notification) => _notification = notification;
        public void sendMessage(User user, string message)
        {
            _notification.SendMessage(user,message);
        }
    }
}
