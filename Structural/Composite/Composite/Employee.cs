/// <summary>
/// Represents an Employee who can have child dependents.
/// Implements the 'Composite' in the Composite pattern.
/// </summary>


namespace Composite
{
    public class Employee : Person
    {
        // Holds the list of dependent nodes associated with this employee.
        public List<Person> peopleList = new List<Person>();

        public Employee(int id, string name, string title, int age, string relationship)
            : base(id, name, title, age, relationship)
        {
        }

        // Adds a dependent (child node) to this employee.
        public override void Add(Person person)
        {
            peopleList.Add(person);
        }

        // Removes a dependent from this employee.
        public override void Remove(Person person)
        {
            peopleList.Remove(person);
        }

        // Prints the employee's name and recursively prints all dependents.
        public override void PrintTree()
        {
            Console.WriteLine($"Employee : {Title}.{Name}");
            Console.WriteLine("Dependents :");
            foreach (Person person in peopleList)
            {
                person.PrintTree();
            }
        }
    }
}
