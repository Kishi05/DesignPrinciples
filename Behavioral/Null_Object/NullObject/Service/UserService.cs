using NullObject.Interface;

namespace NullObject.Service
{
    public class UserService
    {
        private readonly ILogger _logger;
        public UserService(ILogger logger)
        {
            _logger = logger;
        }

        public void RegisterUser(string username)
        {
            // some business logic
            _logger.Log($"User '{username}' registered.");
        }
    }
}
