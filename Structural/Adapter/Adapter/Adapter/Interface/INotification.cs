// INotification.cs
// -----------------------------------------------------------
// This is the common interface used across all notification
// channels (SMS, Email, Cloud). Each Adapter implements this
// interface to allow polymorphic usage and runtime switching.
// -----------------------------------------------------------
using Adapter.Entity;

namespace Adapter.Adapter.Interface
{
    public interface INotification
    {
        public void SendMessage(User user);
    }
}
