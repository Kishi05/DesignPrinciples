using Observer.Reciever.Abstract;
using Observer.From.Abstract;

namespace Observer.Reciever
{
    public class Receiver : ReceiverAbstract
    {

        protected string _name;
        public event EventHandler<SenderAbstract> MessageReceived = null;
        public Receiver(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override void Update(SenderAbstract sender)
        {
            if (sender != null && MessageReceived != null)
            {
                Console.WriteLine($"Receiver : {Name}");
                MessageReceived(this, sender);
            }
        }
    }
}
