// -----------------------------------------------------------
// Program.cs
// -----------------------------------------------------------
// Entry point of the application.
// - Creates a sample user with notification preferences.
// - Uses Factory + Adapter to send notifications via SMS, Email, and Cloud.
// -----------------------------------------------------------

using Facade.Entity;
using Facade.Facade;

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

NotificationServiceFacade.SendNotification(user);