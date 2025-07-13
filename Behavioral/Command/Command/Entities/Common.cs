using Command.Enum;

namespace Command.Entities
{
    public class Common
    {
        public string Appliance {  get; set; }
        public CommandOption CommandOption { get; set; }
        public bool Power {  get; set; } = false;
        public DateTime Timer { get; set; }
    }
}
