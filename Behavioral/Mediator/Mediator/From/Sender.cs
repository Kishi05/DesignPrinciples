using Mediator.From.Abstract;

namespace Mediator.From
{
    public class Sender : SenderAbstract
    {
        public Sender(string? name)
        {
            if(name is not null)
                _name = name;
        }
    }
}
