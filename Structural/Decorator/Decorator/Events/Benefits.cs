using Decorator.Adapter.Interface;
using Decorator.Builder;
using Decorator.Entity;
using Decorator.Factory;

namespace Decorator.Events
{
    public class Benefits
    {
        private NotificationServiceType _serviceType;
        public Benefits(NotificationServiceType serviceType) => _serviceType = serviceType;
        public void SendMessage(User user, string message)
        {
            INotification _notification = new DecoratorPipeLineBuilder(_serviceType)
                                    .Build();

            _notification.SendMessage(user, message);
        }
    }
}
