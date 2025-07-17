using State.Abstract;

namespace State.States
{
    internal class Completed : AbstractState
    {
        public static readonly Completed Instance = new Completed();
        public override AbstractState Process()
        {
            Console.WriteLine("Process Complete");
            return this;
        }
    }
}
