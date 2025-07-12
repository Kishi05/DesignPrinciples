namespace Facade.Entity
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool isSMSOpted { get; set; }
        public bool isEmailOpted { get; set; }
        public bool isChatOpted { get; set; }
    }
}
