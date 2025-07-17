using State.Abstract;

namespace State.States
{
    internal class Idle : AbstractState
    {
        public override AbstractState Process()
        {
            Console.WriteLine("Idle State");
            return new Loaded();
        }
    }
}
