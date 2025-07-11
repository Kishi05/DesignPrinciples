// -----------------------------------------------------------
// Program.cs
// -----------------------------------------------------------
// Entry point of the application.
// - Creates a sample user with notification preferences.
// - Uses Factory + Adapter to send notifications via SMS, Email, and Cloud.
// -----------------------------------------------------------

using Bridge.Bridge;
using Bridge.Entity;

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

UserNotificationBridge obj  = new UserNotificationBridge();
obj.isNewJoiner(user);