namespace Command.Devices.Interface
{
    public interface IDevices
    {
        public Task SetTimer(int minutes);

        public Task TurnOFF();

        public Task TurnON();
    }
}
