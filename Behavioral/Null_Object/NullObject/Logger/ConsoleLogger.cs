using NullObject.Interface;

namespace NullObject.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Console] {message}");
        }
    }
}
