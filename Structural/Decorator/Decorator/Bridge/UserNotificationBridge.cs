
/// <summary>
/// Bridge pattern implementation to handle user notification scenarios.
/// Manages service fallback and sequences multiple notification events.
/// </summary>

using Decorator.Entity;
using Decorator.Events;
using Decorator.Factory;

namespace Decorator.Bridge
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
            WelcomeMessage message = new WelcomeMessage(typeVal);
            message.SendMessage(user, "Welcome to our Team !!");

            Credentials cred = new Credentials(typeVal);
            cred.SendMessage(user, "Please find attached your UserName and OTP.");

            Benefits benefits = new Benefits(typeVal);
            benefits.SendMessage(user, "Health Benefits are ready to avail..!");
        }
    }
}
