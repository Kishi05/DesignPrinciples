namespace Strategy.Interface
{
    /// <summary>
    /// Strategy interface for all discount types.
    /// Declares a method to apply discount on a given amount.
    /// </summary>
    internal interface IDiscount
    {
        double ApplyDiscount(double amount);
    }
}
