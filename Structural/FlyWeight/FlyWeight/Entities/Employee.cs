namespace FlyWeight.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Country Country { get; set; }

    }
}
