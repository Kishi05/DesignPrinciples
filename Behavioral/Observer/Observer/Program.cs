using Observer.Reciever;
using Observer.Sender;
using Observer.Sender.Abstract;

SenderAbstract sender = new Sender("Sam");

Receiver receiver = new Receiver("Jackie");

sender.Subscribe(receiver);
sender.Send("Hi!");