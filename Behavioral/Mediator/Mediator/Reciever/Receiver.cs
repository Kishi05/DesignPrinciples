using Mediator.From.Abstract;
using Mediator.Reciever.Abstract;
using System;

namespace Mediator.Reciever
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

        public void SendMessage(SenderAbstract sender,string message)
        {
            sender.Name = _name;
            sender.Send(message);
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
