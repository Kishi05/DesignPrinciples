using Observer.From;
using Observer.From.Abstract;
using Observer.Reciever;
using Observer.Reciever.Abstract;

namespace Observer.Facade
{
    public class Message
    {
        private SenderAbstract sender;
        public Message(string name) => sender = new Sender("Sam");

        public Message AddReceiver(string name)
        {
            Receiver receiver = new Receiver(name);
            receiver.MessageReceived += PrintMessage;
            sender.Subscribe(receiver);
            return this;
        }

        public Message RemoveReceiver(ReceiverAbstract receiver)
        {
            sender.Unsubscribe(receiver);
            return this;
        }

        public Message Send(string message)
        {
            sender.Send(message);
            return this;
        }

        private void PrintMessage(object? obj, SenderAbstract sender)
        {
            Console.WriteLine($" ------------  Message  ------------ ");
            Console.WriteLine($"{sender.Name} : {sender.Message}\n");
        }
    }
}
