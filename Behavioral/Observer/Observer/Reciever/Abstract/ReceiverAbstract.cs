using Observer.Sender.Abstract;

namespace Observer.Reciever.Abstract
{
    public abstract class ReceiverAbstract
    {
        public abstract void Update(SenderAbstract sender);
    }
}
