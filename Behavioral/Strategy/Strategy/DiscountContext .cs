using Strategy;
using Strategy.Enum;
using Strategy.Interface;

namespace Strategy
{
    /// <summary>
    /// Context class to encapsulate strategy resolution and execution.
    /// </summary>
    internal class DiscountContext
    {
        public static IDiscount ResolveDiscountStrategy(DiscountType type)
        {
            return type switch
            {
                DiscountType.None => new NoDiscount(),
                DiscountType.Normal => new NormalDiscount(),
                DiscountType.Student => new StudentDiscount(),
                _ => GetDefaultDiscount(type)
            };
        }

        public static double ApplyDiscount(IDiscount discount, double amount)
        {
            return discount.ApplyDiscount(amount);
        }

        private static IDiscount GetDefaultDiscount(DiscountType type)
        {
            Console.WriteLine($"[WARN] Unknown discount type: {type}, applying NoDiscount by default.");
            return new NoDiscount();
        }

    }
}
