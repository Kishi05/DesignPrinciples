/// <summary>
/// Manages the root-level persons in a dependency tree structure.
/// Provides methods to add, remove, and print the organizational chart.
/// </summary>
namespace Composite
{
    public class DependencyChart
    {
        private readonly List<Person> persons = new();

        /// <summary>
        /// Adds a root-level person to the chart if not already present.
        /// </summary>
        /// <param name="person">The person to add.</param>
        /// <exception cref="ArgumentNullException">Thrown if person is null.</exception>
        public void AddRoot(Person person)
        {
            if (person == null) throw new ArgumentNullException();
            if (!persons.Any(x => x.Id == person.Id))
            {
                persons.Add(person);
            }
        }

        /// <summary>
        /// Removes a root-level person from the chart.
        /// </summary>
        /// <param name="person">The person to remove.</param>
        /// /// <exception cref="ArgumentNullException">Thrown if person is null.</exception>
        public void RemoveRoot(Person person)
        {
            if (person == null) throw new ArgumentNullException();
            persons.Remove(person);
        }

        /// <summary>
        /// Prints all top-level trees in the dependency chart.
        /// </summary>
        public void PrintChart()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(Environment.NewLine);
                person.PrintTree();
            }
        }
    }
}
