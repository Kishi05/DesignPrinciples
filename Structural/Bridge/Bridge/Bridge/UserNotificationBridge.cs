using Bridge.Adapter.Interface;
using Bridge.Entity;
using Bridge.Events;
using Bridge.Factory;

namespace Bridge.Bridge
{
    public class UserNotificationBridge
    {
        public void isNewJoiner(User user)
        {
            try
            {
                if (user.isEmailOpted)
                {
                    MessagingService(user, NotificationServiceType.Email);
                }
            }
            catch (NotificationFailureException ex)
            {
                Console.WriteLine($"[Fallback Triggered] Email failed: {ex.Message}. Switching to Cloud.");

                if (user.isChatOpted)
                {
                    MessagingService(user, NotificationServiceType.Cloud);
                }
            }
        }

        public void MessagingService(User user, NotificationServiceType typeVal)
        {
            INotification notification = NotificationServiceFactory.GetServe(typeVal);

            WelcomeMessage message = new WelcomeMessage(notification);
            message.sendMessage(user, "Welcome to our Team !!");

            Credentials cred = new Credentials(notification);
            cred.sendMessage(user, "Please find attached your UserName and OTP.");

            Benefits benefits = new Benefits(notification);
            benefits.sendMessage(user, "Health Benefits are ready to avail..!");
        }
    }
}
