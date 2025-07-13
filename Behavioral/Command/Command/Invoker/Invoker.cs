using Command.Command.Interface;

namespace Command.Invoker
{
    public static class Invoker
    {
        public static Queue<ICommandLine> cmdQueue = new();
        public static Stack<ICommandLine> undoCmd = new();

        public static void AddCommand(ICommandLine command)
        {
            cmdQueue.Enqueue(command);
        }

        public static Queue<ICommandLine> GetList()
        {
            return cmdQueue;
        }

        public static void Undo()
        {
            if (cmdQueue.Count == 0)
                return;

            // Remove last command from queue (FIFO queue -> remove last enqueued item)
            var tempQueue = new Queue<ICommandLine>();
            ICommandLine? lastCommand = null;

            while (cmdQueue.Count > 0)
            {
                var cmd = cmdQueue.Dequeue();
                if (cmdQueue.Count == 0)
                {
                    lastCommand = cmd;
                    break;
                }
                tempQueue.Enqueue(cmd);
            }

            if (lastCommand != null)
                undoCmd.Push(lastCommand);

            // Restore remaining queue
            cmdQueue = tempQueue;
        }

        public static void Redo()
        {
            if (undoCmd.Any())
                cmdQueue.Enqueue(undoCmd.Pop());
        }
    }
}
