using Strategy.Interface;

namespace Strategy
{
    /// <summary>
    /// Concrete strategy that applies no discount.
    /// </summary>
    internal class NoDiscount : IDiscount
    {
        public double ApplyDiscount(double amount)
        {
            return amount;
        }
    }
}
