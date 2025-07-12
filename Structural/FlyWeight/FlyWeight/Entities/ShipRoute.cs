namespace FlyWeight.Entities
{
    public class ShipRoute
    {
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public Country FromCountry { get; set; }
        public Country ToCountry { get; set; }
        public Ship Ship { get; set; }
    }
}
