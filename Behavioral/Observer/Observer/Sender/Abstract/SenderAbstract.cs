using Observer.Reciever.Abstract;

namespace Observer.Sender.Abstract
{
    public abstract class SenderAbstract
    {
        List<ReceiverAbstract> receivers = new();

        protected string _name;

        private string _message {  get; set; }

        public string Message 
        { 
            get 
            {
                return _message;
            }
            set
            {
                _message = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Subscribe(ReceiverAbstract receiver)
        {
            receivers.Add(receiver);
        }

        public void Unsubscribe(ReceiverAbstract receiver)
        {
            receivers.Remove(receiver);
        }

        public void BroadCast()
        {
            if (receivers.Any())
            {
                foreach (ReceiverAbstract receiver in receivers)
                {
                    receiver.Update(this);
                }
            }
        }

        public void Send(string message)
        {
            Message = message;
            BroadCast();
        }

    }
}
