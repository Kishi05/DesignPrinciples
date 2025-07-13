using Command.Devices.Interface;
using Command.Entities;

namespace Command.Devices
{
    public class Lights : ISHACommand
    {
        public Common common { get; set; }

        public Lights()
        {
            common = new Common();
            common.Appliance = "Light";
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
