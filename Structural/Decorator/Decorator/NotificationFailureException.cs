
/// <summary>
/// Custom exception type representing notification send failures.
/// Used to trigger retry and fallback logic in decorators and bridge.
/// </summary>

namespace Decorator
{
    public class NotificationFailureException : Exception
    {
        public NotificationFailureException() :base()
        {
            
        }

        public NotificationFailureException(string? message) : base(message)
        {

        }

        public NotificationFailureException(string? message, Exception? inner) : base(message, inner)
        {

        }
    }
}
