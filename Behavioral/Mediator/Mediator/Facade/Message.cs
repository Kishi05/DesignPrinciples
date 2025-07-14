using Mediator.From;
using Mediator.From.Abstract;
using Mediator.Reciever;
using Mediator.Reciever.Abstract;
using System;

namespace Mediator.Facade
{
    public class Message
    {
        private SenderAbstract sender;

        public Message CreateSender(string? name = null)
        {
            sender = new Sender(name);
            return this;
        }

        public SenderAbstract GetSender() => sender;

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
