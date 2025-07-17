namespace Visitor
{
    /// <summary>
    /// Represents the element object on which visitors operate.
    /// Each method simulates a payment operation.
    /// </summary>
    internal class Payment
    {
        private readonly double _amount;

        public Payment(double amount)
        {
            _amount = amount;
        }

        public void OneTimePayment()
        {
            Console.WriteLine($"One Time Payment: Paid {_amount}");
        }

        public void RecurringPayment()
        {
            Console.WriteLine($"Recurring Payment: Paid {_amount}");
        }

        public void PaymentRefund()
        {
            Console.WriteLine($"Refund Payment: Paid {_amount}");
        }

    }
}
