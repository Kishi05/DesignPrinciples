using Strategy;
using Strategy.Enum;

double amount = 10;
Console.WriteLine($"Amount : {amount}");

Console.WriteLine($"Student Discount : {DiscountContext.ApplyDiscount(DiscountContext.ResolveDiscountStrategy(DiscountType.Student), amount)}");

Console.WriteLine($"No Discount : {DiscountContext.ApplyDiscount(DiscountContext.ResolveDiscountStrategy(DiscountType.None), amount)}");

Console.WriteLine($"Normal Discount : {DiscountContext.ApplyDiscount(DiscountContext.ResolveDiscountStrategy(DiscountType.Normal), amount)}");