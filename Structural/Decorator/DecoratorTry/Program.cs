using Decorator;

ICoffee coffee = new SimpleCoffee();
coffee = new Milk(coffee);
coffee = new Sugar(coffee);

Console.WriteLine(coffee.GetDescription()); // "Simple Coffee, Milk, Sugar"
Console.WriteLine(coffee.GetCost());        // 130
