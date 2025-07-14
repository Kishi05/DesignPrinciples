using Abstract.Abstract;

namespace Abstract
{
    public class CreditCardPayment : Payment
    {
        public override void PaymentDetails()
        {
            string? CardNumber = null;
            string? CardHolderName = null;
            DateTime? ExpirationDate= null;
            bool isInvalid = true;

            Console.WriteLine("Enter Card Details :");

            do
            {
                Console.WriteLine("\nEnter Card Number :");
                CardNumber = Console.ReadLine();
            } while (CardNumber is null);

            do
            {
                Console.WriteLine("\nEnter Card Holder Name :");
                CardHolderName = Console.ReadLine();
            } while (CardHolderName is null);

            do
            {
                try
                {
                    Console.WriteLine("\nEnter Expiration Date :");
                    ExpirationDate = DateTime.Parse(Console.ReadLine());
                    isInvalid = false;
                }
                catch (FormatException)
                {
                    Console.Write("Invalid Format. Expected Format (mm/dd/YYYY)\n");
                    isInvalid = true;
                }
                catch (InvalidCastException)
                {
                    isInvalid = true;
                }
            }while(isInvalid);

            Console.WriteLine("\nPayment will now process...");

        }

        public override void ProcessPayment()
        {
            Console.WriteLine("\nCredit Card Payment Processed");
        }
    }
}
