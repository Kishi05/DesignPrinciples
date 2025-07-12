
namespace Decorator
{
    interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }

    class SimpleCoffee : ICoffee
    {
        public string GetDescription() => "Simple Coffee";
        public double GetCost() => 100;
    }

    // Decorator base
    abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee coffee;
        public CoffeeDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }
        public virtual string GetDescription() => coffee.GetDescription();
        public virtual double GetCost() => coffee.GetCost();
    }

    // Concrete decorators
    class Milk : CoffeeDecorator
    {
        public Milk(ICoffee coffee) : base(coffee) { }
        public override string GetDescription() => coffee.GetDescription() + ", Milk";
        public override double GetCost() => coffee.GetCost() + 20;
    }

    class Sugar : CoffeeDecorator
    {
        public Sugar(ICoffee coffee) : base(coffee) { }
        public override string GetDescription() => coffee.GetDescription() + ", Sugar";
        public override double GetCost() => coffee.GetCost() + 10;
    }

}