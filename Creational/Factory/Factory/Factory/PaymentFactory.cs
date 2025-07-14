using Factory.Abstract;
using Factory.Enum;

namespace Factory.Factory
{
    public static class PaymentFactory
    {
        public static Payment PaymentMethod(PaymentType? type)
        {
            if (type is null) return null;

            Payment? returnObj = null;

            switch (type)
            {
                case PaymentType.CreditCard:
                    returnObj = new CreditCardPayment();
                    break;
                case PaymentType.UPI:
                    returnObj = new UPIPayment();
                    break;
                default:
                    throw new ArgumentException("Invalid Payment Type.");
            }

            return returnObj;

        }
    }
}
