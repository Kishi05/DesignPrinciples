using Builder.Builder.Interface;

namespace Builder.Builder
{
    public class UPIBuilder : IPaymentBuilder
    {
        string? UPIID = null;

        public IPaymentBuilder Build()
        {
            return new UPIBuilder();
        }

        public UPIBuilder GetUPIID()
        {
            bool isInValid = false;
            do
            {
                isInValid = false;
                Console.WriteLine("\nEnter UPI ID :");
                UPIID = Console.ReadLine();

                if (String.IsNullOrEmpty(UPIID) || String.IsNullOrWhiteSpace(UPIID))
                {
                    Console.WriteLine("UPI ID is Required");
                    isInValid = true;
                }

            } while (isInValid);

            return this;
        }

        public UPIPayment PaymentObject()
        {
            return new UPIPayment(UPIID);
        }

    }
}
