using Builder.Abstract;

namespace Builder
{
    public class UPIPayment : Payment
    {
        readonly string? _UPIID = null;

        public UPIPayment(string? UPIID)
        {
            _UPIID = UPIID;
        }

        public override void InitiatePayment()
        {
            Console.WriteLine("\nPayment will now process...");
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("\nUPI Payment Processed");
        }
    }
}
