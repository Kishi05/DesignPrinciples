using Factory.Abstract;

namespace Factory
{
    public class UPIPayment : Payment
    {
        public override void PaymentDetails()
        {
            string? UPIID = null;

            Console.WriteLine("Enter UPI Details :");

            do
            {
                Console.WriteLine("\nEnter UPI ID :");
                UPIID = Console.ReadLine();
            } while (UPIID is null);

            Console.WriteLine("\nPayment will now process...");

        }

        public override void ProcessPayment()
        {
            Console.WriteLine("\nUPI Payment Processed");
        }
    }
}
