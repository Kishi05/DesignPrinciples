
/// <summary>
/// Fluent builder for composing a decorator pipeline around a notification service.
/// Enables adding decorators like logging and retry in a configurable manner.
/// </summary>

using Decorator.Adapter.Decorator;
using Decorator.Adapter.Interface;
using Decorator.Factory;

namespace Decorator.Builder
{
    public class DecoratorPipeLineBuilder
    {
        private INotification _notification;

        public DecoratorPipeLineBuilder(NotificationServiceType serviceType)
        {
            _notification = NotificationServiceFactory.GetServe(serviceType);
        }
        public DecoratorPipeLineBuilder WithLogging() 
        {
            _notification = new LogNotificationDecorator(_notification);
            return this;
        }
        public DecoratorPipeLineBuilder WithRetry(int retryCount = 3)
        {
            _notification = new RetryNotificationDecorator(_notification, retryCount);
            return this;
        }
        public INotification Build()
        {
            return _notification;
        }
    }
}
