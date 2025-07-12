namespace Proxy.Entity
{
    public class Receipt
    {
        public string? Confirmation { get; set; }

        public override string ToString()
        {
            return $"Confirmation : {Confirmation}";
        }
    }
}
