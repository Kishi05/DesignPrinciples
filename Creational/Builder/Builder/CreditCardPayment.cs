using Builder.Abstract;

namespace Builder
{
    public class CreditCardPayment : Payment
    {

        readonly string? _cardNumber = null;
        readonly string? _cardHolderName = null;
        readonly DateTime? _expirationDate = null;

        public CreditCardPayment(string? CardNumber, string? CardHolderName, DateTime? ExpirationDate)
        {
            _cardNumber = CardNumber;
            _cardHolderName = CardHolderName;
            _expirationDate = ExpirationDate;
        }

        public override void InitiatePayment()
        {
            Console.WriteLine("\nPayment will now process...");
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("\nCredit Card Payment Processed");
        }
    }
}
