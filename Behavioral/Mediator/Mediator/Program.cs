using Mediator.Facade;
using Mediator.Reciever;

Message msg = new Message();

msg.CreateSender().AddReceiver("Jackie");

Receiver from = new Receiver("Mark");
from.SendMessage(msg.GetSender(),"Hi From Mark !");

Message msg1 = new Message();
msg1.CreateSender("System").AddReceiver("Antony").Send("BroadCast from system..!");