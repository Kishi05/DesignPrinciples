using NullObject.Interface;

namespace NullObject.Logger
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("log.txt", $"[File] {message}\n");
        }
    }
}
