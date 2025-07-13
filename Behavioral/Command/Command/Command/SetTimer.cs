using Command.Command.Interface;
using Command.Devices.Interface;

namespace Command.Command
{
    public class SetTimer : ICommandLine
    {
        private IDevices _device;
        private int _minutes;
        public SetTimer(IDevices device, int minutes)
        {
            _device = device;
            _minutes = minutes;
        }
        public async Task Execute()
        {
            await _device.SetTimer(_minutes);
        }
    }
}
