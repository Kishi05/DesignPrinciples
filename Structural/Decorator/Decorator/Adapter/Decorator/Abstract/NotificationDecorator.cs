
/// <summary>
/// Base decorator class implementing <see cref="INotification"/>.
/// Wraps an existing notification instance and delegates calls to it.
/// Provides extension points for additional responsibilities (e.g., logging, retry).
/// </summary>

using Decorator.Adapter.Interface;
using Decorator.Entity;

namespace Decorator.Adapter.Decorator.Interface
{
    public abstract class NotificationDecorator : INotification
    {
        protected INotification _notification;

        protected NotificationDecorator(INotification notification) { 
            _notification = notification;
        }

        public virtual void SendMessage(User user, string message) => _notification.SendMessage(user, message);
    }
}
