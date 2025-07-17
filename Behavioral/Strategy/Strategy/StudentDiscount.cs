using Strategy.Interface;

namespace Strategy
{
    /// <summary>
    /// Concrete strategy that applies a 10% student discount.
    /// </summary>
    internal class StudentDiscount : IDiscount
    {
        private const double discountPercent = 10;
        public double ApplyDiscount(double amount)
        {
            return amount - ((discountPercent / 100) * amount);
        }
    }
}
