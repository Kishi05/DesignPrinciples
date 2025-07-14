using Builder.Builder;
using Builder.Builder.Interface;
using Builder.Enum;

namespace Builder.Factory
{
    public static class PaymentBuilderFactory
    {
        public static IPaymentBuilder PaymentMethod(PaymentType? type)
        {
            if (type is null) return null;

            IPaymentBuilder? returnObj = null;

            switch (type)
            {
                case PaymentType.CreditCard:
                    returnObj = new CreditCardBuilder();
                    break;
                case PaymentType.UPI:
                    returnObj = new UPIBuilder();
                    break;
                default:
                    throw new ArgumentException("Invalid Payment Type.");
            }

            return returnObj;

        }
    }
}
