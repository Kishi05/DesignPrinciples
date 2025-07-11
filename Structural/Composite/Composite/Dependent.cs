/// <summary>
/// Represents a Dependent who cannot have child nodes.
/// Implements the 'Leaf' in the Composite pattern.
/// </summary>

namespace Composite
{
    public class Dependent : Person
    {
        public Dependent(int id, string name, string title, int age, string relationship)
            : base(id, name, title, age, relationship)
        {
        }

        // Operation not supported. Dependents cannot have children.
        // <exception cref="InvalidOperationException">Always thrown.</exception>
        public override void Add(Person person)
        {
            throw new InvalidOperationException("Dependents cannot have dependents");
        }

        public override void Remove(Person person)
        {
            throw new InvalidOperationException("Dependents cannot have dependents");
        }

        // Prints the dependent's title, name, and relationship.
        public override void PrintTree()
        {
            Console.WriteLine($"{Title}.{Name} [{RelationShip}]");
        }
    }
}
