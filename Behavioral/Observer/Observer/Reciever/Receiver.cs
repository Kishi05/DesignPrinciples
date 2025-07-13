using Observer.Reciever.Abstract;
using Observer.Sender.Abstract;

namespace Observer.Reciever
{
    public class Receiver : ReceiverAbstract
    {
        private string _name;

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
            if (sender != null)
            {
                Console.WriteLine($"Receiver : {Name}");
                Console.WriteLine($" ------------  Message  ------------ ");
                Console.WriteLine($"{sender.Name} : {sender.Message}");
            }
        }
    }
}
