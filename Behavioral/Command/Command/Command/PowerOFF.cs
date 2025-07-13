using Command.Command.Interface;
using Command.Devices.Interface;

namespace Command.Command
{
    public class PowerOFF : ICommandLine
    {
        private IDevices _device;
        public PowerOFF(IDevices device)
        {
            _device = device;
        }
        public async Task Execute()
        {
            await _device.TurnOFF();
        }
    }
}
