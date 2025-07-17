using Iterator;
using Iterator.Entity;
using Iterator.Interface;

TCollection<User> collection = new();
IIterator<User> iterator = collection
                                .Add(new User()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Sam"
                                })
                                .Add(new User()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Mike"
                                })
                                .Add(new User()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "John"
                                })
                                .Add(new User()
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Samual"
                                }).GetIterator();

try
{
    Console.WriteLine(iterator.CurrentNode());
    Console.WriteLine(iterator.Next());
    Console.WriteLine(iterator.Next());
    Console.WriteLine(iterator.CurrentNode());
    Console.WriteLine(iterator.Next());
    Console.WriteLine(iterator.Next());
    Console.WriteLine(iterator.First());
    iterator.Reset();
    Console.WriteLine(iterator.CurrentNode());

    Console.WriteLine(iterator.Next());
    Console.WriteLine(iterator.Next());
    Console.WriteLine(iterator.Next());
    Console.WriteLine(iterator.Next());
    Console.WriteLine(iterator.Next());
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}