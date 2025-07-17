using State.Abstract;
using State.States;

namespace State
{
    internal class StateContext
    {
        private AbstractState _state { get; set; } = new Idle();

        private void Process()
        {
            _state = _state.Process();
        }

        public void Run()
        {
            while(_state is not Completed)
            {
                Process();
            }

            Process();
        }

    }
}
