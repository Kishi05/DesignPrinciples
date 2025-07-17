using Strategy.Interface;

namespace Strategy 
{
    /// <summary>
    /// Concrete strategy that applies a normal 5% discount.
    /// </summary>
    internal class NormalDiscount : IDiscount
    {
        private const double discountPercent = 5;
        public double ApplyDiscount(double amount)
        {
            return amount - ((discountPercent / 100) * amount);
        }
    }
}
