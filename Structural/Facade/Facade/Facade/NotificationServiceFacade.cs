
// NotificationServiceFacade.cs
// -----------------------------------------------------------
// FACADE PATTERN IMPLEMENTATION
// -----------------------------------------------------------
// This class provides a simplified, unified interface for sending 
// notifications through various channels (SMS, Email, Cloud).
// Internally, it hides the complexity of adapter instantiation and 
// service selection by leveraging the Factory pattern.
//
// KEY RESPONSIBILITIES:
// - Acts as a Facade over the Adapter and Factory layers.
// - Delegates message sending to appropriate services based on 
//   user preferences.
// - Promotes separation of concerns and reduces client-side complexity.
//
// This facade allows client code to trigger all opted-in notifications 
// with a single method call without managing dependencies or logic.
// -----------------------------------------------------------


using Facade.Entity;
using Facade.Factory;

namespace Facade.Facade
{
    public static class NotificationServiceFacade
    {
        public static void SendNotification(User user)
        {
            //Calling respective service if required
            if (user.isSMSOpted)
                NotificationServiceFactory.GetServe(NotificationServiceType.SMS).SendMessage(user);

            if (user.isEmailOpted)
                NotificationServiceFactory.GetServe(NotificationServiceType.Email).SendMessage(user);

            if (user.isChatOpted)
                NotificationServiceFactory.GetServe(NotificationServiceType.Cloud).SendMessage(user);
        }
    }
}
