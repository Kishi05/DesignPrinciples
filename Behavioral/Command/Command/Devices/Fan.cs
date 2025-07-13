using Command.Devices.Interface;
using Command.Entities;

namespace Command.Devices
{
    public class Fan : ISHACommand
    {
        public Common common { get; set; }

        public Fan() {
            common = new Common();
            common.Appliance = "Fan";
        }

        public void SetTimer(int minutes)
        {
            common.CommandOption = Enum.CommandOption.SetTimer;
            common.Timer = DateTime.UtcNow.AddMinutes(minutes);
        }

        public void TurnOFF()
        {
            common.CommandOption = Enum.CommandOption.TurnOFF;
            common.Power = false;
        }

        public void TurnON()
        {
            common.CommandOption = Enum.CommandOption.TurnON;
            common.Power = true;
        }
    }
}
