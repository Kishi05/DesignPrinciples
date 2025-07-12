
/// <summary>
/// Concrete decorator adding retry logic to notifications.
/// Attempts to resend the message a configurable number of times on failure.
/// </summary>

using Decorator.Adapter.Decorator.Interface;
using Decorator.Adapter.Interface;
using Decorator.Entity;

namespace Decorator.Adapter.Decorator
{
    public class RetryNotificationDecorator : NotificationDecorator
    {
        private readonly int _retryCount;
        public RetryNotificationDecorator(INotification notification, int retryCount = 3) : base(notification)
        {
            _retryCount = retryCount;
        }

        public override void SendMessage(User user, string message)
        {
            int retry = 0;
            while (retry < _retryCount)
            {
                try
                {
                    _notification.SendMessage(user, message);
                    throw new NotificationFailureException();
                }
                catch (NotificationFailureException ex)
                {
                    Console.WriteLine($"Retrying... Attempt {retry + 1} of {_retryCount + 1}");
                    Console.WriteLine(ex.Message.ToString());
                    retry++;
                }
            }
        }
    }
}
