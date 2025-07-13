using Observer.Facade;

Message msg = new Message("Sam");

msg.AddReceiver("Jackie").AddReceiver("Mani")
    .Send("Hi !");