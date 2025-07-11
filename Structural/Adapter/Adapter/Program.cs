// -----------------------------------------------------------
// Program.cs
// -----------------------------------------------------------
// Entry point of the application.
// - Creates a sample user with notification preferences.
// - Uses Factory + Adapter to send notifications via SMS, Email, and Cloud.
// -----------------------------------------------------------

using Adapter.Entity;
using Adapter.Factory;

User user = new User()
{
    Id = Guid.NewGuid(),
    Name = "Sam",
    PhoneNumber = "9876543210",
    Email = "sam@dp.net",
    isSMSOpted = true,
    isEmailOpted = true,
    isChatOpted = true

};

//Calling respective service if required
if(user.isSMSOpted)
    NotificationServiceFactory.GetServe(NotificationServiceType.SMS).SendMessage(user);

if(user.isEmailOpted)
    NotificationServiceFactory.GetServe(NotificationServiceType.Email).SendMessage(user);

if(user.isChatOpted)
    NotificationServiceFactory.GetServe(NotificationServiceType.Cloud).SendMessage(user);