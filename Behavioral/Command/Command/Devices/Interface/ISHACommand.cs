using Command.Entities;

namespace Command.Devices.Interface
{
    public interface ISHACommand
    {
        public Common common { get; set; }
        public void TurnON();
        public void TurnOFF();
        public void SetTimer(int minutes);
    }
}
