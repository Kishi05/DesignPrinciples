using NullObject.Interface;

namespace NullObject.Logger
{
    public class NullLogger : ILogger
    {
        public void Log(string message)
        {
            // Do nothing
        }
    }
}
