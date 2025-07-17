using State.Abstract;

namespace State.States
{
    internal class Dispatched : AbstractState
    {
        public override AbstractState Process()
        {
            Console.WriteLine("Item Dispatched");
            return new Completed();
        }
    }
}
