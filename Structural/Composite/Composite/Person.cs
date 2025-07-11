/// <summary>
/// Abstract base class representing a person in the hierarchy.
/// Serves as the 'Component' in the Composite design pattern.
/// Declares the interface for all nodes in the tree (composite or leaf).
/// </summary>

namespace Composite
{
    public abstract class Person
    {
        protected Person(int id, string name, string title, int age, string relationship)
        {
            this.Id = id;
            this.Name = name;
            this.Title = title;
            this.Age = age;
            this.RelationShip = relationship;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Age { get; set; }
        public string RelationShip { get; set; }

        public abstract void Add(Person person);

        public abstract void Remove(Person person);

        public abstract void PrintTree();

    }
}
