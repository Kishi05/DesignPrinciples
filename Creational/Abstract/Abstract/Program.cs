using Abstract;
using Abstract.Abstract;

Payment payment = new CreditCardPayment();
payment.PaymentDetails();
payment.ProcessPayment();

Console.WriteLine();

payment = new UPIPayment();
payment.PaymentDetails();
payment.ProcessPayment();