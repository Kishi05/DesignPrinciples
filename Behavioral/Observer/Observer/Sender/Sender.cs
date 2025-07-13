using Observer.Sender.Abstract;

namespace Observer.Sender
{
    public class Sender : SenderAbstract
    {
        public Sender(string name)
        {
            _name = name;
        }
    }
}
