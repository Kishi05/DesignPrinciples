namespace Command.Devices
{
    public class Fan : Interface.IDevices
    {
        public async Task SetTimer(int minutes)
        {
            await Task.Delay(3000);
            Console.WriteLine($"Fan - Timer Set to : {DateTime.UtcNow.AddMinutes(minutes)}");
        }

        public async Task TurnOFF()
        {
            await Task.Delay(1000);
            Console.WriteLine("Fan - Power OFF");
        }

        public async Task TurnON()
        {
            await Task.Delay(1000);
            Console.WriteLine("Fan - Power ON");
        }
    }
}
