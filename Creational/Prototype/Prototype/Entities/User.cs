namespace Prototype.Entities
{
    public class User : ICloneable
    {
        public string Name {  get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public User DeepClone()
        {
            User userCopy = (User)this.MemberwiseClone();
            userCopy.Address = new Address();
            userCopy.Address.Street = this.Address.Street;
            userCopy.Address.City = this.Address.City;
            userCopy.Address.PostalCode = this.Address.PostalCode;

            return userCopy;
        }

    }
}