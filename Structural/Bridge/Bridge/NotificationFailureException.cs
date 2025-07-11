namespace Bridge
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
