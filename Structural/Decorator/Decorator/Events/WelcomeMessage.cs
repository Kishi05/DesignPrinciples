using Decorator.Adapter.Interface;
using Decorator.Builder;
using Decorator.Entity;
using Decorator.Factory;

namespace Decorator.Events
{
    public class WelcomeMessage
    {
        private NotificationServiceType _serviceType;
        public WelcomeMessage(NotificationServiceType serviceType) => _serviceType = serviceType;
        public void SendMessage(User user, string message)
        {
            INotification _notification = new DecoratorPipeLineBuilder(_serviceType)
                                    .WithLogging()
                                    .WithRetry(2)
                                    .Build();

            _notification.SendMessage(user, message);
        }
    }
}
