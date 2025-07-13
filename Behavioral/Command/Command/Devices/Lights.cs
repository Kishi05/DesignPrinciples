namespace Command.Devices
{
    public class Lights : Interface.IDevices
    {
        public async Task SetTimer(int minutes)
        {
            await Task.Delay(1000);
            Console.WriteLine($"Light - Timer Set to : {DateTime.UtcNow.AddMinutes(minutes)}");
        }

        public async Task TurnOFF()
        {
            await Task.Delay(1000);
            Console.WriteLine("Light - Power OFF");
        }

        public async Task TurnON()
        {
            await Task.Delay(1000);
            Console.WriteLine("Light - Power ON");
        }
    }
}
