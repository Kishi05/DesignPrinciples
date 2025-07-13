using Command.Devices.Interface;

namespace Command.Invoker
{
    public static class Invoker
    {
        public static Queue<ISHACommand> cmdQueue = new();
        public static ISHACommand? undoCmd;
        public static void ExecuteCMD(ISHACommand command)
        {
            string cmd = $"{command.common.Appliance} - ";
            switch (command.common.CommandOption)
            {
                case Enum.CommandOption.TurnON:
                    cmd += "Turned ON";
                    break;
                case Enum.CommandOption.TurnOFF:
                    cmd += "Turned OFF";
                    break;
                case Enum.CommandOption.SetTimer:
                    cmd += $"Timer Set to : {command.common.Timer}";
                    break;
                default:
                    throw new InvalidOperationException("Invalid Operation");
            }

            Console.WriteLine(cmd);
        }

        public static void AddCommand(ISHACommand command)
        {
            cmdQueue.Enqueue(command);
        }

        public static Queue<ISHACommand> GetList()
        {
            return cmdQueue;
        }

        public static void Undo()
        {
            undoCmd = cmdQueue.Dequeue();
        }

        public static void Redo()
        {
            if(undoCmd != null)
                cmdQueue.Enqueue(undoCmd);
        }
    }
}
