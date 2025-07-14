namespace Singleton
{
    public class LogConsole
    {
        private static readonly LogConsole _instance = new LogConsole();
        private static readonly object _instanceLock = new object();

        public static LogConsole Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    return _instance;
                }
            }
        }

        private LogConsole() 
        {
        }


        public void LogDebug(string message)
        {
            Console.WriteLine($"Debug : {message}");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"Info : {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"Warning : {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"Error : {message}");
        }

        public static void Debug(string message)
        {
            Instance.LogDebug(message);
        }

        public static void Info(string message)
        {
            Instance.LogInfo(message);
        }

        public static void Warning(string message)
        {
            Instance.LogWarning(message);
        }

        public static void Error(string message)
        {
            Instance.LogError(message);
        }

    }
}
