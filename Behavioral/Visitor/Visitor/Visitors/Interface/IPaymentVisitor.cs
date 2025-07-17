using Visitor.Enum;

namespace Visitor.Visitors.Interface
{
    /// <summary>
    /// Visitor interface declaring operations for different payment types.
    /// Concrete implementations like UPI or CreditCard will define specific behavior.
    /// </summary>
    internal interface IPaymentVisitor
    {
        IPaymentVisitor ProcessPayment(Payment payment, PaymentType type);
        IPaymentVisitor Logging();
    }
}
