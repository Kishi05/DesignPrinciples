using Visitor.Enum;
using Visitor.Visitors.Interface;

namespace Visitor.Visitors
{
    /// <summary>
    /// Concrete Visitor for processing UPI payments.
    /// Implements singleton pattern for instance reuse.
    /// </summary>
    internal class UPI : IPaymentVisitor
    {

        #region One Way of creating object
        //private static IPaymentVisitor _instance;
        //private static readonly object _lock = new object();

        //public static IPaymentVisitor Visitor
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            lock (_lock)
        //            {
        //                if (_instance == null)
        //                    _instance = new UPI();
        //            }
        //        }
        //        return _instance;
        //    }
        //}
        #endregion

        private static readonly Lazy<IPaymentVisitor> _instance = new(() => new UPI());

        public static IPaymentVisitor Visitor => _instance.Value;

        public IPaymentVisitor ProcessPayment(Payment payment, PaymentType type)
        {
            Console.Write($"[ {PaymentMethodType.UPI} ] ");
            switch (type)
            {
                case PaymentType.OneTimePayment:
                    payment.OneTimePayment();
                    break;
                case PaymentType.RecurringPayment:
                    payment.RecurringPayment();
                    break;
                case PaymentType.Refund:
                    payment.PaymentRefund();
                    break;
                default:
                    throw new InvalidOperationException($"Unsupported type: {type}");
            }
            return this;
        }

        public IPaymentVisitor Logging()
        {
            Console.WriteLine($"[ {PaymentMethodType.UPI} ] - Logging");
            return this;
        }

    }
}
