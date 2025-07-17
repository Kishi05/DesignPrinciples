using State.Abstract;

namespace State.States
{
    internal class Loaded : AbstractState
    {
        public override AbstractState Process()
        {
            Console.WriteLine("Money Loaded");
            return new Dispatched();
        }
    }
}
