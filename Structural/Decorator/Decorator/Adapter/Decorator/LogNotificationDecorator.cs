
/// <summary>
/// Concrete decorator adding logging functionality to notifications.
/// Logs messages after sending via the wrapped notification instance.
/// </summary>

using Decorator.Adapter.Decorator.Interface;
using Decorator.Adapter.Interface;
using Decorator.Entity;

namespace Decorator.Adapter.Decorator
{
    public class LogNotificationDecorator : NotificationDecorator
    {
        public LogNotificationDecorator(INotification notification) : base(notification)
        {

        }

        public override void SendMessage(User user, string message)
        {
            _notification.SendMessage(user, message);
            Console.WriteLine("Log : " + message);
        }
    }
}
