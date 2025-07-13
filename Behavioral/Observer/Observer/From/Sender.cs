using Observer.From.Abstract;

namespace Observer.From
{
    public class Sender : SenderAbstract
    {
        public Sender(string name)
        {
            _name = name;
        }
    }
}
