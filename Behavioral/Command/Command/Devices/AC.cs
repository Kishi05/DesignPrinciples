using Command.Devices.Interface;

namespace Command.Devices
{
    public class AC : IDevices
    {
        public async Task SetTimer(int minutes)
        {
            await Task.Delay(1000);
            Console.WriteLine($"AC - Timer Set to : {DateTime.UtcNow.AddMinutes(minutes)}");
        }

        public async Task TurnOFF()
        {
            await Task.Delay(1000);
            Console.WriteLine("AC - Power OFF");
        }

        public async Task TurnON()
        {
            await Task.Delay(1000);
            Console.WriteLine("AC - Power ON");
        }
    }
}
