using Builder.Builder.Interface;

namespace Builder.Builder
{
    public class CreditCardBuilder : IPaymentBuilder
    {
        string? CardNumber = null;
        string? CardHolderName = null;
        DateTime? ExpirationDate = null;

        public IPaymentBuilder Build()
        {
            return new CreditCardBuilder();
        }

        public CreditCardBuilder GetCardNumber()
        {
            bool isInValid = false;
            do
            {
                isInValid = false;
                Console.WriteLine("\nEnter Card Number :");
                CardNumber = Console.ReadLine();

                if(String.IsNullOrEmpty(CardNumber) || String.IsNullOrWhiteSpace(CardNumber))
                {
                    Console.WriteLine("Card Number is Required");
                    isInValid = true;
                }

            } while (isInValid);

            return this;
        }

        public CreditCardBuilder GetCardHolderName()
        {
            bool isInValid = false;
            do
            {
                isInValid = false;
                Console.WriteLine("\nEnter Card Holder Name :");
                CardHolderName = Console.ReadLine();

                if (String.IsNullOrEmpty(CardHolderName) || String.IsNullOrWhiteSpace(CardHolderName))
                {
                    Console.WriteLine("Card Holder Name is Required");
                    isInValid = true;
                }

            } while (isInValid);

            return this;
        }

        public CreditCardBuilder GetExpirationDate()
        {
            bool isValid = false;
            do
            {
                try
                {
                    Console.WriteLine("\nEnter Expiration Date :");
                    ExpirationDate = DateTime.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (FormatException)
                {
                    Console.Write("Invalid Format. Expected Format (mm/dd/YYYY)\n");
                    isValid = false;
                }
                catch (InvalidCastException)
                {
                    isValid = false;
                }
            } while (!isValid);

            return this;
        }

        public CreditCardPayment PaymentObject()
        {
            return new CreditCardPayment(CardNumber, CardHolderName, ExpirationDate);
        }

    }
}
