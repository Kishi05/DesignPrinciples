using Visitor;
using Visitor.Enum;

Facade.GetVisitor(PaymentMethodType.CreditCard)
      .ProcessPayment(new Payment(10), PaymentType.OneTimePayment)
      .Logging();

Facade.GetVisitor(PaymentMethodType.UPI)
      .ProcessPayment(new Payment(50),PaymentType.OneTimePayment)
      .Logging();