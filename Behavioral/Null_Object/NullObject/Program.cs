using NullObject.Interface;
using NullObject.Logger;
using NullObject.Service;

ILogger logger = new NullLogger(); // or new ConsoleLogger() or new FileLogger()
UserService service = new(logger);
service.RegisterUser("Sam");