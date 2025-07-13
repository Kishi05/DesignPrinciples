using Command.Command.Interface;
using Command.Devices.Interface;

namespace Command.Command
{
    public class PowerON : ICommandLine
    {
        private IDevices _device;
        public PowerON(IDevices device)
        {
            _device = device;
        }
        public async Task Execute()
        {
            await _device.TurnON();
        }
    }
}
