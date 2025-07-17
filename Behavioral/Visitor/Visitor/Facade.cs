using Visitor.Enum;
using Visitor.Visitors;
using Visitor.Visitors.Interface;

namespace Visitor
{
    /// <summary>
    /// Acts as a facade to retrieve appropriate payment visitor
    /// based on the selected payment method type.
    /// </summary>
    internal static class Facade
    {
        public static IPaymentVisitor GetVisitor(PaymentMethodType type)
        {
            return type switch
            {
                PaymentMethodType.CreditCard => CreditCard.Visitor,
                PaymentMethodType.UPI => UPI.Visitor,
                _ => throw new InvalidOperationException($"Unsupported type: {type}")
            };
        }
    }
}
